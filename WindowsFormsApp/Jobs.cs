using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using PdfSharp;
using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace WindowsFormsApp
{
    /// <summary>
    /// Клас вакансії
    /// </summary>
    [Serializable]
    public class Job
    {
        [XmlAttribute("id")]
        public int ID { get; set; }
        [XmlElement("link")]
        public string Link { get; set; }
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("region")]
        public string Region { get; set; }
        [XmlElement("description")]
        public string Description { get; set; }
        [XmlIgnore]
        public DateTime PublicationDate { get; set; }
        [Browsable(false)]
        [XmlElement("pubdate")]
        public string PublicationDateString { get; set; }
        [XmlElement("salary")]
        public ulong Salary { get; set; }
        [XmlElement("company")]
        public string CompanyName { get; set; }
        [XmlIgnore]
        public DateTime ExpirationDate { get; set; }
        [Browsable(false)]
        [XmlElement("expire")]
        public string ExpirationDateString { get; set; }
        [XmlElement("jobtype")]
        public string Type { get; set; }
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Перевірити рядок на коректність
        /// </summary>
        /// <param name="str">Рядок</param>
        /// <returns>Чи коректний рядок</returns>
        public static bool ValidateString(string str)
        {
            return !string.IsNullOrWhiteSpace(str);
        }

        /// <summary>
        /// Перевірити посилання на коректність
        /// </summary>
        /// <param name="link">Посилання</param>
        /// <returns>Чи коректне посилання</returns>
        public static bool ValidateLink(string link)
        {
            return Uri.TryCreate(link, UriKind.Absolute, out Uri uri) &&
                (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps);
        }

        /// <summary>
        /// Перевірити дату на коректність
        /// </summary>
        /// <param name="date">Дата</param>
        /// <returns>Чи коректна дата</returns>
        public static bool ValidateDate(DateTime date)
        {
            return date.Date >= DateTime.Now.Date;
        }

        /// <summary>
        /// Перевірити номер телефону на коректність
        /// </summary>
        /// <param name="str">Рядок, що містить номер телефону</param>
        /// <returns>Чи коректний номер телефону</returns>
        public static bool ValidatePhone(string str)
        {
            string regex1 = @"^(\+380)?\s?\(?(\d{2})\)?\s?(\d{3})\s?(\d{2})\s?(\d{2})$";
            string regex2 = @"^\(?(0\d{2})\)?\s?(\d{3})\s?(\d{2})\s?(\d{2})$";
            return Regex.IsMatch(str, regex1) || Regex.IsMatch(str, regex2);
        }
    }

    /// <summary>
    /// Клас зі списком вакансій
    /// </summary>
    [XmlRoot("jobs")]
    public class JobList
    {
        [XmlElement("job")]
        public BindingList<Job> Jobs { get; set; }

        /// <summary>
        /// Сортування
        /// </summary>
        /// <param name="sorts">Список сортувань</param>
        /// <returns>Відсортований список</returns>
        public List<Job> Sort(List<KeyValuePair<int, int>> sorts)
        {
            // Словник для функцій сортування
            Dictionary<int, Func<Job, object>> sortFunctions = new Dictionary<int, Func<Job, object>>()
            {
                { 0, x => x.ID },
                { 1, x => x.Link },
                { 2, x => x.Name },
                { 3, x => x.Region },
                { 4, x => x.Description },
                { 5, x => x.PublicationDate },
                { 6, x => x.Salary },
                { 7, x => x.CompanyName },
                { 8, x => x.ExpirationDate },
                { 9, x => x.Type },
                { 10, x => x.Phone }
            };

            // Сортування за першим (головним) параметром
            IOrderedEnumerable<Job> jobs = Jobs.OrderBy(sortFunctions[sorts[0].Key]);

            // Сортування за іншими параметрами
            for(int i = 1; i < sorts.Count; i++)
            {
                if(sorts[i].Value == 0)
                {
                    jobs = jobs.ThenBy(sortFunctions[sorts[i].Key]);
                }
                else
                {
                    jobs = jobs.ThenByDescending(sortFunctions[sorts[i].Key]);
                }
            }

            return jobs.ToList();
        }

        /// <summary>
        /// Пошук
        /// </summary>
        /// <param name="kvp">Пара стовбець-значення</param>
        /// <returns>Список зі значеннями, що віповідають пошуку</returns>
        public List<Job> Find(KeyValuePair<int, string> kvp)
        {
            List<Job> jobs = null;
            string s = kvp.Value;

            switch(kvp.Key)
            {
                case 0: // ID
                    jobs = Jobs.Where(x => x.ID == int.Parse(s)).ToList();
                    break;
                case 1: // Вебсайт
                    jobs = Jobs.Where(x => x.Link == s).ToList();
                    break;
                case 2: // Назва
                    jobs = Jobs.Where(x => x.Name == s).ToList();
                    break;
                case 3: // Регіон
                    jobs = Jobs.Where(x => x.Region == s).ToList();
                    break;
                case 4: // Опис
                    jobs = Jobs.Where(x => x.Description == s).ToList();
                    break;
                case 5: // Дата публікації
                    jobs = Jobs.Where(x => x.PublicationDate == DateTime.Parse(s)).ToList();
                    break;
                case 6: // Зарплата
                    jobs = Jobs.Where(x => x.Salary == ulong.Parse(s)).ToList();
                    break;
                case 7: // Компанія
                    jobs = Jobs.Where(x => x.CompanyName == s).ToList();
                    break;
                case 8: // Дата закінчення
                    jobs = Jobs.Where(x => x.ExpirationDate == DateTime.Parse(s)).ToList();
                    break;
                case 9: // Тип вакансії
                    jobs = Jobs.Where(x => x.Type == s).ToList();
                    break;
                case 10: // Номер телефону
                    jobs = Jobs.Where(x => x.Phone == s).ToList();
                    break;
                default:
                    break;
            }

            return jobs;
        }

        /// <summary>
        /// Фільтрація
        /// </summary>
        /// <param name="kvp">Пара стовбець-діапазон значень</param>
        /// <returns>Фільтрований список</returns>
        public List<Job> Filter(KeyValuePair<int, object> kvp)
        {
            List<Job> jobs = null;
            object o = kvp.Value;

            if(kvp.Key == 0) // ID
            {
                int[] ids = (int[])o;
                jobs = Jobs.Where(x => x.ID >= ids[0] && x.ID <= ids[1]).ToList();
            }
            else if(kvp.Key == 6) // Зарплата
            {
                ulong[] uls = (ulong[])o;
                jobs = Jobs.Where(x => x.Salary >= uls[0] && x.Salary <= uls[1]).ToList();
            }
            else if(kvp.Key == 5 /* Дата публікації */ || kvp.Key == 8 /* Дата закінчення */)
            {
                DateTime[] dates = (DateTime[])o;

                if(kvp.Key == 5) // Дата публікації
                {
                    jobs = Jobs.Where(x => x.PublicationDate >= dates[0] &&
                        x.PublicationDate <= dates[1]).ToList();
                }
                else // Дата закінчення
                {
                    jobs = Jobs.Where(x => x.ExpirationDate >= dates[0] &&
                        x.ExpirationDate <= dates[1]).ToList();
                }
            }
            else // Рядки
            {
                string str = (string)o;
                string[] sarr = str.Trim().Replace("\r", "").Split('\n');

                if(kvp.Key == 1) // Вебсайт
                {
                    jobs = Jobs.Where(x => sarr.Contains(x.Link)).ToList();
                }
                else if(kvp.Key == 2) // Назва
                {
                    jobs = Jobs.Where(x => sarr.Contains(x.Name)).ToList();
                }
                else if(kvp.Key == 3) // Регіон
                {
                    jobs = Jobs.Where(x => sarr.Contains(x.Region)).ToList();
                }
                else if(kvp.Key == 4) // Опис
                {
                    jobs = Jobs.Where(x => sarr.Contains(x.Description)).ToList();
                }
                else if(kvp.Key == 7) // Компанія
                {
                    jobs = Jobs.Where(x => sarr.Contains(x.CompanyName)).ToList();
                }
                else if(kvp.Key == 9) // Тип вакансії
                {
                    jobs = Jobs.Where(x => sarr.Contains(x.Type)).ToList();
                }
                else if(kvp.Key == 10) // Номер телефону
                {
                    jobs = Jobs.Where(x => sarr.Contains(x.Phone)).ToList();
                }
            }

            return jobs;
        }

        /// <summary>
        /// Імпортувати з XML файлу
        /// </summary>
        /// <param name="file">Назва файлу</param>
        public void ReadFromXML(string file)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(JobList));
            using(FileStream fs = new FileStream(file, FileMode.Open))
            {
                this.Jobs = ((JobList)serializer.Deserialize(fs)).Jobs;
            }

            for(int i = 0; i < this.Jobs.Count; i++)
            {
                this.Jobs[i].PublicationDate = DateTime.Parse(this.Jobs[i].PublicationDateString);
                this.Jobs[i].ExpirationDate = DateTime.Parse(this.Jobs[i].ExpirationDateString);
            }
        }

        /// <summary>
        /// Експортувати у XML файл
        /// </summary>
        /// <param name="file">Назва файлу</param>
        public void WriteToXML(string file)
        {
            for(int i = 0; i < this.Jobs.Count; i++)
            {
                this.Jobs[i].PublicationDateString = this.Jobs[i].PublicationDate.ToString("dd.MM.yyyy");
                this.Jobs[i].ExpirationDateString = this.Jobs[i].PublicationDate.ToString("dd.MM.yyyy");
            }

            XmlSerializer serializer = new XmlSerializer(typeof(JobList));
            using(FileStream fs = new FileStream(file, FileMode.Create))
            {
                serializer.Serialize(fs, this);
            }
        }

        /// <summary>
        /// Експортувати у PDF файл
        /// </summary>
        /// <param name="file">Назва файлу</param>
        public void WriteToPDF(string file)
        {
            PdfGenerator.GeneratePdf(GenerateHTMLTable(), PageSize.A2).Save(file);
        }

        /// <summary>
        /// Зчитати список з бінарного файлу
        /// </summary>
        /// <param name="file">Назва файлу</param>
        public void ReadFromBinary(string file)
        {
            using(FileStream fileStream = new FileStream(file, FileMode.Open))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Jobs = (BindingList<Job>)binaryFormatter.Deserialize(fileStream);
            }
        }

        /// <summary>
        /// Зберегти список у бінарний файл
        /// </summary>
        /// <param name="file">Назва файлу</param>
        public void WriteToBinary(string file)
        {
            using(FileStream fileStream = new FileStream(file, FileMode.Create))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, Jobs);
            }
        }

        /// <summary>
        /// Побудувати HTML рядок з таблицею
        /// </summary>
        /// <returns>Рядок з таблицею у форматі HTML</returns>
        private string GenerateHTMLTable()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<table><thead><tr><th>ID</th><th>Вебсайт</th><th>Назва</th><th>Регіон</th><th>Опис</th><th>Дата публікації</th><th>Зарплата</th><th>Компанія</th><th>Дата закінчення</th><th>Тип вакансії</th><th>Номери телефону</th></tr></thead><tbody>");

            foreach(Job job in Jobs)
            {
                sb.Append($"<tr><td>{job.ID}</td>");
                sb.Append($"<td>{job.Link}</td>");
                sb.Append($"<td>{job.Name}</td>");
                sb.Append($"<td>{job.Region}</td>");
                sb.Append($"<td>{job.Description}</td>");
                sb.Append($"<td>{job.PublicationDate:dd.MM.yyyy}</td>");
                sb.Append($"<td>{job.Salary}</td>");
                sb.Append($"<td>{job.CompanyName}</td>");
                sb.Append($"<td>{job.ExpirationDate:dd.MM.yyyy}</td>");
                sb.Append($"<td>{job.Type}</td>");
                sb.Append($"<td>{job.Phone}</td></tr>");
            }

            sb.Append("</tbody></table><style type=\"text/css\">table,td,th{border:1px solid}table{width:100%;border-collapse:collapse}td{vertical-align:top}</style>");
            return sb.ToString();
        }
    }
}
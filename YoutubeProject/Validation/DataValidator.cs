using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace YoutubeProject.Validation
{
    class DataValidator : IValidation
    {
        public DataBaseColumn Column { get; set; }
        public string Data { get; set; }

        string firstNamePattern = @"\w{2,50}";
        string secondNamePattern = @"\w{1,50}";
        string emailPattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
        string motherTownPattern = @"[A-Z]{2,50}";
        string passwordPattern = @"[0-9 A-Z a-z _ - \.]{8,50}";
        public DataValidator(string data, DataBaseColumn column)
        {
            this.Data = data;
            this.Column = column;
        }

        public bool IsSatisfied()
        {
            string pattern = string.Empty;
            switch (Column)
            {
                case DataBaseColumn.FirstName:
                    pattern = firstNamePattern;
                    break;
                case DataBaseColumn.SecondName:
                    pattern = secondNamePattern;
                    break;
                case DataBaseColumn.Email:
                    pattern = emailPattern;
                    break;
                case DataBaseColumn.MotherTown:
                    pattern = motherTownPattern;
                    break;
                case DataBaseColumn.Password:
                    pattern = passwordPattern;
                    break;
            }
            if (Regex.IsMatch(Data, pattern, RegexOptions.IgnoreCase))
            {
                return true;
            }
            return false;
        }

        public enum DataBaseColumn
        {
            FirstName,
            SecondName,
            Email,
            MotherTown,
            BirthDate,
            Password,
        }
    }
}

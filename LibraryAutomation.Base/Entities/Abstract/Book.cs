using LibraryAutomation.Base.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Base.Entities.Abstract
{
    public abstract class Book
    {        
        public Guid Id { get; } = Guid.NewGuid();

        private string _title = string.Empty;

        public string Title
        {
            get => _title;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    _title = string.Empty;
                }
                else
                {
                    string trimmed = value.Trim().Replace(" ", "");

                    _title = char.ToUpper(trimmed[0]) + trimmed[1..].ToLower();
                }
            }
        }

        public string Description { get; set; } = string.Empty;

        public Status Status { get; set; }

        public DateTime PublishedDate { get; set; }

        public string Publisher { get; set; } = string.Empty;

        private string _authorFirstName = string.Empty;

        public string AuthorFirstName
        {
            get => _authorFirstName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    _authorFirstName = string.Empty;
                }
                else
                {
                    string trimmed = value.Trim().Replace(" ", "");
                    _authorFirstName = char.ToUpper(trimmed[0]) + trimmed[1..].ToLower();
                }
            }
        }

        private string _authorLastName = string.Empty;

        public string AuthorLastName
        {
            get => _authorLastName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    _authorLastName = string.Empty;
                }
                else
                {
                    string trimmed = value.Trim().Replace(" ", "");
                    _authorLastName = char.ToUpper(trimmed[0]) + trimmed[1..].ToLower();
                }
            }
        }

        public int ISBNNumber { get; set; }

        private int _stock;

        public int Stock
        {
            get => _stock;
            set
            {
                if (value <= 0)
                {
                    _stock = 10;
                }

                _stock = value;
            }
        }
    }
}

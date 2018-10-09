using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Daring.Cineworld.Models
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class Cinema
    {

        private CinemaFilm[] filmsField;

        private string nameField;

        private string rootField;

        private string urlField;

        private byte idField;

        private string phoneField;

        private string addressField;

        private string postcodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("film", IsNullable = false)]
        public CinemaFilm[] films
        {
            get
            {
                return this.filmsField;
            }
            set
            {
                this.filmsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string root
        {
            get
            {
                return this.rootField;
            }
            set
            {
                this.rootField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string phone
        {
            get
            {
                return this.phoneField;
            }
            set
            {
                this.phoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string postcode
        {
            get
            {
                return this.postcodeField;
            }
            set
            {
                this.postcodeField = value;
            }
        }
    }

    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class CinemaFilm
    {

        private CinemaFilmShow[] showsField;

        private string synopsisField;

        private string posterField;

        private string castField;

        private string directorField;

        private string lengthField;

        private string titleField;

        private string ratingField;

        private string urlField;

        private uint ediField;

        private string releaseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("show", IsNullable = false)]
        public CinemaFilmShow[] shows
        {
            get
            {
                return this.showsField;
            }
            set
            {
                this.showsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string synopsis
        {
            get
            {
                return this.synopsisField;
            }
            set
            {
                this.synopsisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string poster
        {
            get
            {
                return this.posterField;
            }
            set
            {
                this.posterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cast
        {
            get
            {
                return this.castField;
            }
            set
            {
                this.castField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string director
        {
            get
            {
                return this.directorField;
            }
            set
            {
                this.directorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string length
        {
            get
            {
                return this.lengthField;
            }
            set
            {
                this.lengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rating
        {
            get
            {
                return this.ratingField;
            }
            set
            {
                this.ratingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint edi
        {
            get
            {
                return this.ediField;
            }
            set
            {
                this.ediField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string release
        {
            get
            {
                return this.releaseField;
            }
            set
            {
                this.releaseField = value;
            }
        }
    }

    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class CinemaFilmShow
    {

        private string dateField;

        private string timeField;

        private string audioTypeField;

        private string videoTypeField;

        private bool subtitledField;

        private bool subtitledFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string time
        {
            get
            {
                return this.timeField;
            }
            set
            {
                this.timeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string audioType
        {
            get
            {
                return this.audioTypeField;
            }
            set
            {
                this.audioTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string videoType
        {
            get
            {
                return this.videoTypeField;
            }
            set
            {
                this.videoTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool subtitled
        {
            get
            {
                return this.subtitledField;
            }
            set
            {
                this.subtitledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool subtitledSpecified
        {
            get
            {
                return this.subtitledFieldSpecified;
            }
            set
            {
                this.subtitledFieldSpecified = value;
            }
        }
    }
}

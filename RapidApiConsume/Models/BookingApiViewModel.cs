﻿namespace RapidApiConsume.Models
{
    public class BookingApiViewModel
    {

            public Data data { get; set; }

        public class Data
        {
            public Hotel[] hotels { get; set; }
            public Meta[] meta { get; set; }
            public Appear[] appear { get; set; }
        }

        public class Hotel
        {
            public int hotel_id { get; set; }
            public string accessibilityLabel { get; set; }
            public Property1 property { get; set; }
        }

        public class Property1
        {
            public int position { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public float longitude { get; set; }
            public bool isPreferred { get; set; }
            public int rankingPosition { get; set; }
            public string countryCode { get; set; }
            public int accuratePropertyClass { get; set; }
            public int qualityClass { get; set; }
            public int propertyClass { get; set; }
            public string wishlistName { get; set; }
            public string[] blockIds { get; set; }
            public string checkinDate { get; set; }
            public string checkoutDate { get; set; }
            public float latitude { get; set; }
            public string reviewScoreWord { get; set; }
            public string[] photoUrls { get; set; }
            public int mainPhotoId { get; set; }
            public string currency { get; set; }
            public int reviewCount { get; set; }
            public int optOutFromGalleryChanges { get; set; }
            public float reviewScore { get; set; }
            public int ufi { get; set; }
            public bool isFirstPage { get; set; }
            public bool isPreferredPlus { get; set; }
        }

        public class Meta
        {
            public string title { get; set; }
        }

        public class Appear
        {
            public string contentUrl { get; set; }
            public string id { get; set; }
        }




        //public Hotel[] hotels { get; set; }

        //public class Hotel
        //{
        //    public Property1[] property { get; set; }
        //}

        //public class Property1
        //{
        //    public float reviewScore { get; set; }
        //    public int mainPhotoId { get; set; }
        //    public string name { get; set; }
        //    public string checkoutDate { get; set; }
        //    public int optOutFromGalleryChanges { get; set; }
        //    public string reviewScoreWord { get; set; }
        //    public string wishlistName { get; set; }
        //    public string currency { get; set; }
        //    public bool isFirstPage { get; set; }
        //    public float longitude { get; set; }
        //    public string countryCode { get; set; }
        //    public int position { get; set; }
        //    public float latitude { get; set; }
        //    public int id { get; set; }
        //    public int accuratePropertyClass { get; set; }
        //    public int propertyClass { get; set; }
        //    public string[] blockIds { get; set; }
        //    public int rankingPosition { get; set; }
        //    public string[] photoUrls { get; set; }
        //    public int ufi { get; set; }
        //    public string checkinDate { get; set; }
        //    public int reviewCount { get; set; }
        //    public int qualityClass { get; set; }
        //    public bool isPreferred { get; set; }
        //}
    }
}

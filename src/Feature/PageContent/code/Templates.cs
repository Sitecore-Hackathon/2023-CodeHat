using Sitecore.Data;


namespace CodeHat.Feature.PageContent
{
    public static class Templates
    {
        public struct ImageCrop
        {
            public static ID ID = new ID("{6A6D0661-8F85-4AC1-8067-3DD80EA46E37}");

            public struct Fields
            {
                public static ID Image = new ID("{4A363EE8-537F-4DFA-85A1-31822BA9914E}");
                public static ID Title = new ID("{2D8DDEE1-5EF5-43D3-B4CE-11E508B21C18}");
                public static ID UploadButtonText = new ID("{0503124D-7C33-4416-ADF0-D7CE0A0939B5}");
                public static ID SaveButtonText = new ID("{FAEC5E6C-549E-49F6-892A-D7C5F5BBB085}");
                public static ID ConfirmationMessage = new ID("{2B2A0AAC-3FB8-411D-9A3A-EDE9E1249A4B}");
                public static ID ErrorMessage = new ID("{F63E878C-8954-40D0-A233-6253D3122261}");
            }
        }
    }
}
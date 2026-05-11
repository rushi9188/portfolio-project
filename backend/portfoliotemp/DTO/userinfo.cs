namespace portfoliotemp.DTO
{
    public class userinfo
    {
        public string username { get; set; }
        public string email { get; set; }
        public string phonenumber { get; set; }
        public string message { get; set; }

        public string useratr()
        {
            return username + " " + email + " " + phonenumber;
        }
    }
}

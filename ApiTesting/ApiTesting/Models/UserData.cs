using Newtonsoft.Json;
using System;
using ApiTesting.Utils;
using ApiTesting.Models.UserDataFields;

namespace ApiTesting.Models
{
    public class UserData
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("username")]
        public string Username { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("address")]
        public Address Address { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("website")]
        public string Website { get; set; }
        [JsonProperty("company")]
        public Company Company { get; set; }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            else
            {
                bool sameBasics = this.Name == ((UserData)obj).Name &&
                    this.Username == ((UserData)obj).Username &&
                    this.Email == ((UserData)obj).Email &&
                    Phone == ((UserData)obj).Phone &&
                    Website == ((UserData)obj).Website;

                bool sameAddress = this.Address.Street == ((UserData)obj).Address.Street &&
                    this.Address.Suite == ((UserData)obj).Address.Suite &&
                    this.Address.City == ((UserData)obj).Address.City &&
                    this.Address.Zipcode == ((UserData)obj).Address.Zipcode &&
                    this.Address.Geo.Lat == ((UserData)obj).Address.Geo.Lat &&
                    this.Address.Geo.Lng == ((UserData)obj).Address.Geo.Lng;

                bool sameCompany = this.Company.Name == ((UserData)obj).Company.Name &&
                    this.Company.CatchPhrase == ((UserData)obj).Company.CatchPhrase &&
                    this.Company.Bs == ((UserData)obj).Company.Bs;

                return sameBasics && sameAddress && sameCompany;
            }                
        }
    }   
}

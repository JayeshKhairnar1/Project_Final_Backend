using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;

namespace DotNetProject.Models
{
    [Table("user")]
    public partial class User
    {
        private static readonly Random _random = new Random();

        [JsonPropertyName("userid")]
        public string Userid
        {
            get => _userid;
            set
            {
                // If the new value is null or empty, generate a random Userid
                _userid = string.IsNullOrEmpty(value) ? GenerateRandomUserId() : value;
            }
        }

        private string _userid = GenerateRandomUserId(); // Initial Userid

        [JsonPropertyName("address_line1")]
        public string? AddressLine1 { get; set; }

        [JsonPropertyName("address_line2")]
        public string? AddressLine2 { get; set; }

        [JsonPropertyName("city")]
        public string? City { get; set; }

        [JsonPropertyName("company_name")]
        public string? CompanyName { get; set; }

        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonPropertyName("gst_number")]
        public string? GstNumber { get; set; }

        [JsonPropertyName("password")]
        public string? Password { get; set; }

        [JsonPropertyName("pin_code")]
        public string? PinCode { get; set; }

        [JsonPropertyName("state")]
        public string? State { get; set; }

        [JsonPropertyName("telephone")]
        public string? Telephone { get; set; }

        [JsonPropertyName("username")]
        public string? Username { get; set; }

        private static string GenerateRandomUserId()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Range(1, 10).Select(_ => chars[_random.Next(chars.Length)]).ToArray());
        }
    }
}

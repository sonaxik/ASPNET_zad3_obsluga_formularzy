using System.ComponentModel.DataAnnotations;

namespace ASPNET_zad3_obsluga_formularzy.Models
{
    public class Rejestracja
    {
        [Required(ErrorMessage = "Proszę podać imię")]
        [MinLength(2, ErrorMessage = "Imię musi mieć co najmniej 2 znaki")]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Proszę podać nazwisko")]
        [MinLength(2, ErrorMessage = "Nazwisko musi mieć co najmniej 2 znaki")]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Proszę podać adres e-mail")]
        [EmailAddress(ErrorMessage = "Niepoprawny format adresu e-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Proszę podać hasło")]
        [MinLength(8, ErrorMessage = "Hasło musi mieć co najmniej 8 znaków")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$", ErrorMessage = "Hasło musi zawierać co najmniej jedną cyfrę, jedną małą i jedną dużą literę")]
        [DataType(DataType.Password)]
        public string Haslo { get; set; }

        [Required(ErrorMessage = "Proszę potwierdzić hasło")]
        [Compare("Haslo", ErrorMessage = "Hasła muszą być takie same")]
        [DataType(DataType.Password)]
        public string PotwierdzenieHasla { get; set; }

        [Required(ErrorMessage = "Proszę podać numer telefonu")]
        [Phone(ErrorMessage = "Niepoprawny format numeru telefonu")]
        public string NrTelefonu { get; set; }

        [Range(10, 80, ErrorMessage = "Wiek musi być pomiędzy 10 a 80 lat")]
        public int Wiek { get; set; }

        [Required(ErrorMessage = "Proszę wybrać miasto")]
        public Miasta Miasto { get; set; }
    }

    public enum Miasta
    {
        Warszawa,
        Krakow,
        Gdansk,
        Wroclaw,
        Poznan
    }
}

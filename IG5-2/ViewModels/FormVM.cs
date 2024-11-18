using System.ComponentModel.DataAnnotations;

namespace IG5_2.ViewModels
{
    public class FormVM
    {
        [Required(ErrorMessage = "Libelle obligatoire")]
        [RegularExpression("^[A-Za-z0-9 ]+$", ErrorMessage = "Le libelle doit respecter le format requis.")]
        public string Libelle { get; set; }

        [Required(ErrorMessage = "Code obligatoire")]
        [MinLength(3, ErrorMessage = "Le code doit contenir au moins 3 caractères.")]
        public string Code { get; set; }
        public string? Description { get; set; }

        [Required(ErrorMessage = "Prix obligatoire")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Le prix doit être supérieur à 0.")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Choisissez si livraison est disponible.")]
        public bool Livraison { get; set; }

        [Required(ErrorMessage = "Choisissez un mode de paiement.")]
        public string ModeDePaiement { get; set; }
        
    }
    }

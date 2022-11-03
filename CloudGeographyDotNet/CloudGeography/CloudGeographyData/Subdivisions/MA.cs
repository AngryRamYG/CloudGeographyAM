using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMA()
    {
        AddSubdivisions("MA", new List<Subdivision>()
        {
            new(){ Code ="AGD", LocalName="Agadir-Ida-Outanane", Name="Agadir-Ida-Outanane", Type="Prefecture" },
            new(){ Code ="HAO", LocalName="Al Haouz", Name="Al Haouz", Type="Province" },
            new(){ Code ="HOC", LocalName="Al Hoceïma", Name="Al Hoceïma", Type="Province" },
            new(){ Code ="AOU", LocalName="Aousserd", Name="Aousserd", Type="Prefecture" },
            new(){ Code ="ASZ", LocalName="Assa-Zag", Name="Assa-Zag", Type="Province" },
            new(){ Code ="AZI", LocalName="Azilal", Name="Azilal", Type="Province" },
            new(){ Code ="BES", LocalName="Ben Slimane", Name="Ben Slimane", Type="Province" },
            new(){ Code ="BEM", LocalName="Beni Mellal", Name="Beni Mellal", Type="Province" },
            new(){ Code ="BER", LocalName="Berkane", Name="Berkane", Type="Province" },
            new(){ Code ="BOD", LocalName="Boujdour", Name="Boujdour", Type="Province" },
            new(){ Code ="BOM", LocalName="Boulemane", Name="Boulemane", Type="Province" },
            new(){ Code ="CAS", LocalName="Casablanca", Name="Casablanca", Type="Prefecture" },
            new(){ Code ="CHE", LocalName="Chefchaouene", Name="Chefchaouene", Type="Province" },
            new(){ Code ="CHI", LocalName="Chichaoua", Name="Chichaoua", Type="Province" },
            new(){ Code ="CHT", LocalName="Chtouka-Ait Baha", Name="Chtouka-Ait Baha", Type="Province" },
            new(){ Code ="HAJ", LocalName="El Hajeb", Name="El Hajeb", Type="Province" },
            new(){ Code ="JDI", LocalName="El Jadida", Name="El Jadida", Type="Province" },
            new(){ Code ="ERR", LocalName="Errachidia", Name="Errachidia", Type="Province" },
            new(){ Code ="ESM", LocalName="Es Smara", Name="Es Smara", Type="Province" },
            new(){ Code ="ESI", LocalName="Essaouira", Name="Essaouira", Type="Province" },
            new(){ Code ="FAH", LocalName="Fahs-Beni Makada", Name="Fahs-Beni Makada", Type="Prefecture" },
            new(){ Code ="FES", LocalName="Fès-Dar-Dbibegh", Name="Fès-Dar-Dbibegh", Type="Prefecture" },
            new(){ Code ="FIG", LocalName="Figuig", Name="Figuig", Type="Province" },
            new(){ Code ="GUE", LocalName="Guelmim", Name="Guelmim", Type="Province" },
            new(){ Code ="IFR", LocalName="Ifrane", Name="Ifrane", Type="Province" },
            new(){ Code ="INE", LocalName="Inezgane-Ait Melloul", Name="Inezgane-Ait Melloul", Type="Prefecture" },
            new(){ Code ="JRA", LocalName="Jrada", Name="Jrada", Type="Province" },
            new(){ Code ="KES", LocalName="Kelaat Sraghna", Name="Kelaat Sraghna", Type="Province" },
            new(){ Code ="KEN", LocalName="Kénitra", Name="Kénitra", Type="Province" },
            new(){ Code ="KHE", LocalName="Khemisset", Name="Khemisset", Type="Province" },
            new(){ Code ="KHN", LocalName="Khenifra", Name="Khenifra", Type="Province" },
            new(){ Code ="KHO", LocalName="Khouribga", Name="Khouribga", Type="Province" },
            new(){ Code ="LAA", LocalName="Laâyoune", Name="Laâyoune", Type="Province" },
            new(){ Code ="LAR", LocalName="Larache", Name="Larache", Type="Province" },
            new(){ Code ="MMD", LocalName="Marrakech-Medina", Name="Marrakech-Medina", Type="Prefecture" },
            new(){ Code ="MMN", LocalName="Marrakech-Menara", Name="Marrakech-Menara", Type="Prefecture" },
            new(){ Code ="MED", LocalName="Médiouna", Name="Médiouna", Type="Province" },
            new(){ Code ="MEK", LocalName="Meknès*", Name="Meknès*", Type="Prefecture" },
            new(){ Code ="MOH", LocalName="Mohammadia", Name="Mohammadia", Type="Prefecture" },
            new(){ Code ="MOU", LocalName="Moulay Yacoub", Name="Moulay Yacoub", Type="Province" },
            new(){ Code ="NAD", LocalName="Nador", Name="Nador", Type="Province" },
            new(){ Code ="NOU", LocalName="Nouaceur", Name="Nouaceur", Type="Province" },
            new(){ Code ="OUA", LocalName="Ouarzazate", Name="Ouarzazate", Type="Province" },
            new(){ Code ="OUD", LocalName="Oued ed Dahab", Name="Oued ed Dahab", Type="Province" },
            new(){ Code ="OUJ", LocalName="Oujda-Angad", Name="Oujda-Angad", Type="Prefecture" },
            new(){ Code ="RAB", LocalName="Rabat", Name="Rabat", Type="Prefecture" },
            new(){ Code ="SAF", LocalName="Safi", Name="Safi", Type="Province" },
            new(){ Code ="SAL", LocalName="Salé", Name="Salé", Type="Prefecture" },
            new(){ Code ="SEF", LocalName="Sefrou", Name="Sefrou", Type="Province" },
            new(){ Code ="SET", LocalName="Settat", Name="Settat", Type="Province" },
            new(){ Code ="SIK", LocalName="Sidi Kacem", Name="Sidi Kacem", Type="Province" },
            new(){ Code ="SYB", LocalName="Sidi Youssef Ben Ali", Name="Sidi Youssef Ben Ali", Type="Prefecture" },
            new(){ Code ="SKH", LocalName="Skhirate-Témara", Name="Skhirate-Témara", Type="Prefecture" },
            new(){ Code ="TNG", LocalName="Tanger-Assilah", Name="Tanger-Assilah", Type="Prefecture" },
            new(){ Code ="TNT", LocalName="Tan-Tan", Name="Tan-Tan", Type="Province" },
            new(){ Code ="TAO", LocalName="Taounate", Name="Taounate", Type="Province" },
            new(){ Code ="TAI", LocalName="Taourirt", Name="Taourirt", Type="Province" },
            new(){ Code ="TAR", LocalName="Taroudannt", Name="Taroudannt", Type="Province" },
            new(){ Code ="TAT", LocalName="Tata", Name="Tata", Type="Province" },
            new(){ Code ="TAZ", LocalName="Taza", Name="Taza", Type="Province" },
            new(){ Code ="TET", LocalName="Tétouan*", Name="Tétouan*", Type="Prefecture" },
            new(){ Code ="TIZ", LocalName="Tiznit", Name="Tiznit", Type="Province" },
            new(){ Code ="ZAG", LocalName="Zagora", Name="Zagora", Type="Province" }

        });
    }
}

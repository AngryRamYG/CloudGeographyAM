using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBD()
    {
        AddSubdivisions("BD", new List<Subdivision>()
        {
            new(){ Code ="5", LocalName="Bagerhat", Name="Bagerhat", Type="District" },
            new(){ Code ="1", LocalName="Bandarban", Name="Bandarban", Type="District" },
            new(){ Code ="2", LocalName="Barguna", Name="Barguna", Type="District" },
            new(){ Code ="6", LocalName="Barisal", Name="Barisal", Type="District" },
            new(){ Code ="7", LocalName="Bhola", Name="Bhola", Type="District" },
            new(){ Code ="3", LocalName="Bogra", Name="Bogra", Type="District" },
            new(){ Code ="4", LocalName="Brahmanbaria", Name="Brahmanbaria", Type="District" },
            new(){ Code ="9", LocalName="Chandpur", Name="Chandpur", Type="District" },
            new(){ Code ="45", LocalName="Chapai Nawabganj", Name="Chapai Nawabganj", Type="District" },
            new(){ Code ="10", LocalName="Chittagong", Name="Chittagong", Type="District" },
            new(){ Code ="12", LocalName="Chuadanga", Name="Chuadanga", Type="District" },
            new(){ Code ="8", LocalName="Comilla", Name="Comilla", Type="District" },
            new(){ Code ="11", LocalName="Cox's Bazar", Name="Cox's Bazar", Type="District" },
            new(){ Code ="13", LocalName="Dhaka", Name="Dhaka", Type="District" },
            new(){ Code ="14", LocalName="Dinajpur", Name="Dinajpur", Type="District" },
            new(){ Code ="15", LocalName="Faridpur", Name="Faridpur", Type="District" },
            new(){ Code ="16", LocalName="Feni", Name="Feni", Type="District" },
            new(){ Code ="19", LocalName="Gaibandha", Name="Gaibandha", Type="District" },
            new(){ Code ="18", LocalName="Gazipur", Name="Gazipur", Type="District" },
            new(){ Code ="17", LocalName="Gopalganj", Name="Gopalganj", Type="District" },
            new(){ Code ="20", LocalName="Habiganj", Name="Habiganj", Type="District" },
            new(){ Code ="21", LocalName="Jamalpur", Name="Jamalpur", Type="District" },
            new(){ Code ="22", LocalName="Jessore", Name="Jessore", Type="District" },
            new(){ Code ="25", LocalName="Jhalakathi", Name="Jhalakathi", Type="District" },
            new(){ Code ="23", LocalName="Jhenaidah", Name="Jhenaidah", Type="District" },
            new(){ Code ="24", LocalName="Joypurhat", Name="Joypurhat", Type="District" },
            new(){ Code ="29", LocalName="Khagrachhari", Name="Khagrachhari", Type="District" },
            new(){ Code ="27", LocalName="Khulna", Name="Khulna", Type="District" },
            new(){ Code ="26", LocalName="Kishoreganj", Name="Kishoreganj", Type="District" },
            new(){ Code ="28", LocalName="Kurigram", Name="Kurigram", Type="District" },
            new(){ Code ="30", LocalName="Kushtia", Name="Kushtia", Type="District" },
            new(){ Code ="31", LocalName="Lakshmipur", Name="Lakshmipur", Type="District" },
            new(){ Code ="32", LocalName="Lalmonirhat", Name="Lalmonirhat", Type="District" },
            new(){ Code ="36", LocalName="Madaripur", Name="Madaripur", Type="District" },
            new(){ Code ="37", LocalName="Magura", Name="Magura", Type="District" },
            new(){ Code ="33", LocalName="Manikganj", Name="Manikganj", Type="District" },
            new(){ Code ="39", LocalName="Meherpur", Name="Meherpur", Type="District" },
            new(){ Code ="38", LocalName="Moulvibazar", Name="Moulvibazar", Type="District" },
            new(){ Code ="35", LocalName="Munshiganj", Name="Munshiganj", Type="District" },
            new(){ Code ="34", LocalName="Mymensingh", Name="Mymensingh", Type="District" },
            new(){ Code ="48", LocalName="Naogaon", Name="Naogaon", Type="District" },
            new(){ Code ="43", LocalName="Narail", Name="Narail", Type="District" },
            new(){ Code ="40", LocalName="Narayanganj", Name="Narayanganj", Type="District" },
            new(){ Code ="42", LocalName="Narsingdi", Name="Narsingdi", Type="District" },
            new(){ Code ="44", LocalName="Natore", Name="Natore", Type="District" },
            new(){ Code ="41", LocalName="Netrakona", Name="Netrakona", Type="District" },
            new(){ Code ="46", LocalName="Nilphamari", Name="Nilphamari", Type="District" },
            new(){ Code ="47", LocalName="Noakhali", Name="Noakhali", Type="District" },
            new(){ Code ="49", LocalName="Pabna", Name="Pabna", Type="District" },
            new(){ Code ="52", LocalName="Panchagarh", Name="Panchagarh", Type="District" },
            new(){ Code ="51", LocalName="Patuakhali", Name="Patuakhali", Type="District" },
            new(){ Code ="50", LocalName="Pirojpur", Name="Pirojpur", Type="District" },
            new(){ Code ="53", LocalName="Rajbari", Name="Rajbari", Type="District" },
            new(){ Code ="54", LocalName="Rajshahi", Name="Rajshahi", Type="District" },
            new(){ Code ="56", LocalName="Rangamati", Name="Rangamati", Type="District" },
            new(){ Code ="55", LocalName="Rangpur", Name="Rangpur", Type="District" },
            new(){ Code ="58", LocalName="Satkhira", Name="Satkhira", Type="District" },
            new(){ Code ="62", LocalName="Shariatpur", Name="Shariatpur", Type="District" },
            new(){ Code ="57", LocalName="Sherpur", Name="Sherpur", Type="District" },
            new(){ Code ="59", LocalName="Sirajganj", Name="Sirajganj", Type="District" },
            new(){ Code ="61", LocalName="Sunamganj", Name="Sunamganj", Type="District" },
            new(){ Code ="60", LocalName="Sylhet", Name="Sylhet", Type="District" },
            new(){ Code ="63", LocalName="Tangail", Name="Tangail", Type="District" },
            new(){ Code ="64", LocalName="Thakurgaon", Name="Thakurgaon", Type="District" }

        });
    }
}

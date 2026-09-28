using System;

class Program
{
    static void Main(string[] args)
    {
        // ===== OPRETTER 20 BRUGERE FRA START =====
        // bruger nr 1
        telefonnumre[0] = "12345678"; fornavne[0] = "Anna"; efternavne[0] = "Jensen"; aldre[0] = 25; adresser[0] = "Vestergade 1"; postnumre[0] = "1456"; byer[0] = "København"; frekvenser[0] = 12;
        // bruger nr 2
        telefonnumre[1] = "23456789"; fornavne[1] = "Bo"; efternavne[1] = "Nielsen"; aldre[1] = 32; adresser[1] = "Østergade 2"; postnumre[1] = "8000"; byer[1] = "Aarhus"; frekvenser[1] = 4;
        // bruger nr 3
        telefonnumre[2] = "34567890"; fornavne[2] = "Camilla"; efternavne[2] = "Hansen"; aldre[2] = 28; adresser[2] = "Nørregade 3"; postnumre[2] = "5000"; byer[2] = "Odense"; frekvenser[2] = 1;
        // bruger nr 4
        telefonnumre[3] = "45678901"; fornavne[3] = "David"; efternavne[3] = "Pedersen"; aldre[3] = 45; adresser[3] = "Søndergade 4"; postnumre[3] = "9000"; byer[3] = "Aalborg"; frekvenser[3] = 12;
        // bruger nr 5
        telefonnumre[4] = "56789012"; fornavne[4] = "Eva"; efternavne[4] = "Andersen"; aldre[4] = 19; adresser[4] = "Havnegade 5"; postnumre[4] = "6000"; byer[4] = "Kolding"; frekvenser[4] = 4;
        // bruger nr 6
        telefonnumre[5] = "67890123"; fornavne[5] = "Frederik"; efternavne[5] = "Larsen"; aldre[5] = 55; adresser[5] = "Skolegade 6"; postnumre[5] = "7100"; byer[5] = "Vejle"; frekvenser[5] = 1;
        // bruger nr 7
        telefonnumre[6] = "78901234"; fornavne[6] = "Gitte"; efternavne[6] = "Møller"; aldre[6] = 38; adresser[6] = "Kirkegade 7"; postnumre[6] = "4000"; byer[6] = "Roskilde"; frekvenser[6] = 12;
        // bruger nr 8
        telefonnumre[7] = "89012345"; fornavne[7] = "Hans"; efternavne[7] = "Sørensen"; aldre[7] = 22; adresser[7] = "Bredgade 8"; postnumre[7] = "3000"; byer[7] = "Helsingør"; frekvenser[7] = 4;
        // bruger nr 9
        telefonnumre[8] = "90123456"; fornavne[8] = "Ida"; efternavne[8] = "Rasmussen"; aldre[8] = 30; adresser[8] = "Strandvej 9"; postnumre[8] = "2900"; byer[8] = "Hellerup"; frekvenser[8] = 1;
        // bruger nr 10
        telefonnumre[9] = "11223344"; fornavne[9] = "Jakob"; efternavne[9] = "Thomsen"; aldre[9] = 41; adresser[9] = "Parkvej 10"; postnumre[9] = "2100"; byer[9] = "København Ø"; frekvenser[9] = 12;
        // bruger nr 11
        telefonnumre[10] = "22334455"; fornavne[10] = "Karen"; efternavne[10] = "Christensen"; aldre[10] = 27; adresser[10] = "Skovvej 11"; postnumre[10] = "2800"; byer[10] = "Lyngby"; frekvenser[10] = 4;
        // bruger nr 12
        telefonnumre[11] = "33445566"; fornavne[11] = "Lars"; efternavne[11] = "Madsen"; aldre[11] = 50; adresser[11] = "Åboulevarden 12"; postnumre[11] = "8200"; byer[11] = "Aarhus N"; frekvenser[11] = 1;
        // bruger nr 13
        telefonnumre[12] = "44556677"; fornavne[12] = "Mette"; efternavne[12] = "Olsen"; aldre[12] = 35; adresser[12] = "Rosenvej 13"; postnumre[12] = "5230"; byer[12] = "Odense M"; frekvenser[12] = 12;
        // bruger nr 14
        telefonnumre[13] = "55667788"; fornavne[13] = "Niels"; efternavne[13] = "Jørgensen"; aldre[13] = 29; adresser[13] = "Birkevej 14"; postnumre[13] = "2630"; byer[13] = "Taastrup"; frekvenser[13] = 4;
        // bruger nr 15
        telefonnumre[14] = "66778899"; fornavne[14] = "Olivia"; efternavne[14] = "Petersen"; aldre[14] = 23; adresser[14] = "Elmevej 15"; postnumre[14] = "2650"; byer[14] = "Hvidovre"; frekvenser[14] = 1;
        // bruger nr 16
        telefonnumre[15] = "77889900"; fornavne[15] = "Peter"; efternavne[15] = "Winther"; aldre[15] = 60; adresser[15] = "Granvej 16"; postnumre[15] = "2720"; byer[15] = "Vanløse"; frekvenser[15] = 12;
        // bruger nr 17
        telefonnumre[16] = "88990011"; fornavne[16] = "Rita"; efternavne[16] = "Lund"; aldre[16] = 33; adresser[16] = "Fyrrevej 17"; postnumre[16] = "2400"; byer[16] = "København NV"; frekvenser[16] = 4;
        // bruger nr 18
        telefonnumre[17] = "99001122"; fornavne[17] = "Søren"; efternavne[17] = "Berg"; aldre[17] = 47; adresser[17] = "Egevej 18"; postnumre[17] = "2500"; byer[17] = "Valby"; frekvenser[17] = 1;
        // bruger nr 19
        telefonnumre[18] = "10203040"; fornavne[18] = "Tina"; efternavne[18] = "Dam"; aldre[18] = 21; adresser[18] = "Poppelvej 19"; postnumre[18] = "2300"; byer[18] = "København S"; frekvenser[18] = 12;
        // bruger nr 20
        telefonnumre[19] = "50607080"; fornavne[19] = "Ulrik"; efternavne[19] = "Holm"; aldre[19] = 36; adresser[19] = "Kastanievej 20"; postnumre[19] = "2200"; byer[19] = "København N"; frekvenser[19] = 4;

        // nu har vi 20 brugere
        antalBrugere = 20;

        // sætter farver på konsollen
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.Clear();

        // ===== HOVEDMENU =====
        // while-løkke der holder menuen kørende
        bool koerer = true;
        while (koerer)
        {
            // rydder skærmen og viser menuen
            Console.Clear();
            Console.WriteLine("CMIS - Nyhedsbrev Informationsstander");
            Console.WriteLine("Charlie Mørk Information Systems");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1. Tilmeld dig nyhedsbrev");
            Console.WriteLine("2. Admin login");
            Console.WriteLine("3. Afslut");
            Console.WriteLine("------------------------------------");
            Console.Write("Vælg en mulighed: ");

            // læser hvad brugeren taster
            string valg = Console.ReadLine();

            // switch tjekker hvad brugeren valgte
            switch (valg)
            {
                case "1":
                    // ===== OPRET BRUGER =====
                    Console.Clear();
                    Console.WriteLine("Tilmeld dig nyhedsbrev");
                    Console.WriteLine("------------------------------------");

                    // tjekker om der er plads i arrayet
                    if (antalBrugere >= maksAntal)
                    {
                        Console.WriteLine("Der kan ikke oprettes flere brugere.");
                    }
                    else
                    {
                        // beder om telefonnummer
                        Console.Write("Indtast telefonnummer (8 cifre): ");
                        string telefon = Console.ReadLine();

                        // tjekker om nummeret er 8 tegn langt
                        bool telefonGyldig = true;
                        if (telefon == null || telefon.Length != 8)
                        {
                            telefonGyldig = false;
                        }
                        else
                        {
                            // for-løkke der tjekker hvert tegn er et tal
                            for (int i = 0; i < telefon.Length; i++)
                            {
                                if (telefon[i] < '0' || telefon[i] > '9')
                                {
                                    telefonGyldig = false;
                                }
                            }
                        }

                        if (!telefonGyldig)
                        {
                            // giver fejl hvis nummeret ikke er 8 cifre
                            Console.WriteLine("Fejl: Telefonnummeret skal være præcis 8 cifre.");
                        }
                        else
                        {
                            // for-løkke der tjekker om nummeret allerede er i arrayet
                            bool nummerFindes = false;
                            for (int i = 0; i < antalBrugere; i++)
                            {
                                if (telefonnumre[i] == telefon)
                                {
                                    nummerFindes = true;
                                }
                            }

                            if (nummerFindes)
                            {
                                // giver fejl hvis nummeret allerede er registreret
                                Console.WriteLine("Fejl: Dette telefonnummer er allerede registreret.");
                            }
                            else
                            {
                                // nummeret er ledigt - spørger om resten af oplysningerne
                                Console.Write("Indtast fornavn: ");
                                string fornavn = Console.ReadLine();

                                Console.Write("Indtast efternavn: ");
                                string efternavn = Console.ReadLine();

                                // try-catch fanger fejl hvis brugeren skriver bogstaver i stedet for tal
                                Console.Write("Indtast alder: ");
                                string alderInput = Console.ReadLine();
                                int alder = 0;
                                bool alderGyldig = true;

                                try
                                {
                                    // prøver at lave teksten om til et tal
                                    alder = int.Parse(alderInput);
                                    // tjekker om alderen giver mening
                                    if (alder < 1 || alder > 120)
                                    {
                                        alderGyldig = false;
                                    }
                                }
                                catch
                                {
                                    // hvis int.Parse fejler er det ikke et tal
                                    alderGyldig = false;
                                }

                                if (!alderGyldig)
                                {
                                    Console.WriteLine("Fejl: Alder skal være et tal mellem 1 og 120.");
                                }
                                else
                                {
                                    Console.Write("Indtast adresse: ");
                                    string adresse = Console.ReadLine();

                                    Console.Write("Indtast postnummer: ");
                                    string postnummer = Console.ReadLine();

                                    Console.Write("Indtast by: ");
                                    string by = Console.ReadLine();

                                    // spørger om frekvens for nyhedsbrev
                                    Console.WriteLine("");
                                    Console.WriteLine("Hvor ofte vil du modtage nyhedsbrev?");
                                    Console.WriteLine("12 = Hver måned");
                                    Console.WriteLine("4  = Hver tredje måned");
                                    Console.WriteLine("1  = En gang om året");
                                    Console.Write("Vælg frekvens (12, 4 eller 1): ");
                                    string frekvensInput = Console.ReadLine();
                                    int frekvens = 0;
                                    bool frekvensGyldig = false;

                                    try
                                    {
                                        // prøver at lave teksten om til et tal
                                        frekvens = int.Parse(frekvensInput);
                                        // tjekker om det er en af de tilladte værdier
                                        if (frekvens == 12 || frekvens == 4 || frekvens == 1)
                                        {
                                            frekvensGyldig = true;
                                        }
                                    }
                                    catch
                                    {
                                        frekvensGyldig = false;
                                    }

                                    if (!frekvensGyldig)
                                    {
                                        Console.WriteLine("Fejl: Frekvens skal være 12, 4 eller 1.");
                                    }
                                    else
                                    {
                                        // gemmer alle oplysninger i arrays på den næste ledige plads
                                        telefonnumre[antalBrugere] = telefon;
                                        fornavne[antalBrugere] = fornavn;
                                        efternavne[antalBrugere] = efternavn;
                                        aldre[antalBrugere] = alder;
                                        adresser[antalBrugere] = adresse;
                                        postnumre[antalBrugere] = postnummer;
                                        byer[antalBrugere] = by;
                                        frekvenser[antalBrugere] = frekvens;

                                        // tæller op så vi ved der er en bruger mere
                                        antalBrugere++;

                                        Console.WriteLine("Du er nu tilmeldt nyhedsbrevet!");
                                    }
                                }
                            }
                        }
                    }

                    // venter på brugeren trykker en tast
                    Console.WriteLine("Tryk på en tast for at fortsætte...");
                    Console.ReadKey();
                    break;

                case "2":
                    // ===== ADMIN LOGIN =====
                    Console.Clear();
                    Console.WriteLine("Admin Login");
                    Console.WriteLine("------------------------------------");

                    // beder om password
                    Console.Write("Indtast password: ");
                    string password = Console.ReadLine();

                    // tjekker om password er rigtigt
                    if (password == adminPassword)
                    {
                        // password er korrekt - viser admin menu
                        bool adminKoerer = true;
                        while (adminKoerer)
                        {
                            // rydder skærmen og viser admin menuen
                            Console.Clear();
                            Console.WriteLine("Admin Menu");
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("1. Find bruger");
                            Console.WriteLine("2. Vis alle brugere");
                            Console.WriteLine("3. Tilbage til hovedmenu");
                            Console.WriteLine("------------------------------------");
                            Console.Write("Vælg en mulighed: ");

                            // læser admin valg
                            string adminValg = Console.ReadLine();

                            switch (adminValg)
                            {
                                case "1":
                                    // ===== FIND BRUGER =====
                                    Console.Clear();
                                    Console.WriteLine("Find Bruger");
                                    Console.WriteLine("------------------------------------");

                                    // beder om søgeord
                                    Console.Write("Indtast søgeord (navn eller tlf): ");
                                    string soegning = Console.ReadLine();

                                    // array til at gemme index på de brugere der matcher
                                    int[] fundne = new int[maksAntal];
                                    int antalFundne = 0;

                                    // for-løkke der går igennem alle brugere
                                    for (int i = 0; i < antalBrugere; i++)
                                    {
                                        // StringComparison.OrdinalIgnoreCase gør at store og små bogstaver ikke betyder noget
                                        if (telefonnumre[i].Contains(soegning, StringComparison.OrdinalIgnoreCase) ||
                                            fornavne[i].Contains(soegning, StringComparison.OrdinalIgnoreCase) ||
                                            efternavne[i].Contains(soegning, StringComparison.OrdinalIgnoreCase))
                                        {
                                            // gemmer index på den bruger der matchede
                                            fundne[antalFundne] = i;
                                            antalFundne++;
                                        }
                                    }

                                    if (antalFundne == 0)
                                    {
                                        // ingen brugere matchede søgningen
                                        Console.WriteLine("Ingen brugere fundet.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Fundet " + antalFundne + " bruger(e):");
                                        Console.WriteLine("");

                                        // paginering - viser 14 ad gangen
                                        int soegSide = 0;
                                        bool soegViser = true;
                                        while (soegViser)
                                        {
                                            // regner ud hvorfra og hvortil vi skal vise
                                            int soegStart = soegSide * 14;
                                            int soegSlut = soegStart + 14;
                                            if (soegSlut > antalFundne)
                                            {
                                                soegSlut = antalFundne;
                                            }

                                            // overskrift
                                            Console.WriteLine("Tlf\t\tFornavn\t\tEfternavn\tAlder\tFrekvens");
                                            Console.WriteLine("---------------------------------------------------");

                                            // for-løkke der printer brugerne ud
                                            for (int i = soegStart; i < soegSlut; i++)
                                            {
                                                int idx = fundne[i];

                                                // laver frekvens-tallet om til tekst
                                                string frekTekst = "";
                                                if (frekvenser[idx] == 12) { frekTekst = "Månedlig"; }
                                                else if (frekvenser[idx] == 4) { frekTekst = "Kvartårlig"; }
                                                else if (frekvenser[idx] == 1) { frekTekst = "Årlig"; }

                                                // printer en linje med brugerens data
                                                Console.WriteLine(telefonnumre[idx] + "\t" + fornavne[idx] + "\t\t" + efternavne[idx] + "\t" + aldre[idx] + "\t" + frekTekst);
                                            }

                                            // viser hvilken side vi er på
                                            int soegTotalSider = (antalFundne + 13) / 14;
                                            Console.WriteLine("");
                                            Console.WriteLine("Side " + (soegSide + 1) + " af " + soegTotalSider);

                                            // hvis der er flere sider kan man bladre
                                            if (soegSlut < antalFundne)
                                            {
                                                Console.Write("Tryk ENTER for næste side, eller Q for at stoppe: ");
                                                string soegInput = Console.ReadLine();
                                                if (soegInput == "q" || soegInput == "Q")
                                                {
                                                    soegViser = false;
                                                }
                                                else
                                                {
                                                    soegSide++;
                                                    Console.Clear();
                                                }
                                            }
                                            else
                                            {
                                                // sidste side - stopper løkken
                                                soegViser = false;
                                            }
                                        }
                                    }

                                    Console.WriteLine("Tryk på en tast for at fortsætte...");
                                    Console.ReadKey();
                                    break;

                                case "2":
                                    // ===== VIS ALLE BRUGERE =====
                                    Console.Clear();
                                    Console.WriteLine("Vis Alle Brugere");
                                    Console.WriteLine("------------------------------------");

                                    if (antalBrugere == 0)
                                    {
                                        Console.WriteLine("Der er ingen brugere.");
                                    }
                                    else
                                    {
                                        // paginering - viser 14 brugere ad gangen
                                        int alleSide = 0;
                                        bool alleViser = true;
                                        while (alleViser)
                                        {
                                            // regner ud hvorfra og hvortil vi skal vise
                                            int alleStart = alleSide * 14;
                                            int alleSlut = alleStart + 14;
                                            if (alleSlut > antalBrugere)
                                            {
                                                alleSlut = antalBrugere;
                                            }

                                            // overskrift
                                            Console.WriteLine("Tlf\t\tFornavn\t\tEfternavn\tAlder\tFrekvens");
                                            Console.WriteLine("---------------------------------------------------");

                                            // for-løkke der printer alle brugere ud
                                            for (int i = alleStart; i < alleSlut; i++)
                                            {
                                                // laver frekvens-tallet om til tekst
                                                string frekTekst = "";
                                                if (frekvenser[i] == 12) { frekTekst = "Månedlig"; }
                                                else if (frekvenser[i] == 4) { frekTekst = "Kvartårlig"; }
                                                else if (frekvenser[i] == 1) { frekTekst = "Årlig"; }

                                                // printer en linje med brugerens data
                                                Console.WriteLine(telefonnumre[i] + "\t" + fornavne[i] + "\t\t" + efternavne[i] + "\t" + aldre[i] + "\t" + frekTekst);
                                            }

                                            // viser hvilken side vi er på
                                            int alleTotalSider = (antalBrugere + 13) / 14;
                                            Console.WriteLine("");
                                            Console.WriteLine("Side " + (alleSide + 1) + " af " + alleTotalSider);

                                            // hvis der er flere sider kan man bladre
                                            if (alleSlut < antalBrugere)
                                            {
                                                Console.Write("Tryk ENTER for næste side, eller Q for at stoppe: ");
                                                string alleInput = Console.ReadLine();
                                                if (alleInput == "q" || alleInput == "Q")
                                                {
                                                    alleViser = false;
                                                }
                                                else
                                                {
                                                    alleSide++;
                                                    Console.Clear();
                                                }
                                            }
                                            else
                                            {
                                                // sidste side
                                                alleViser = false;
                                            }
                                        }

                                        // kalder funktionen der beregner gennemsnitsalder
                                        double gnsAlder = BeregnGennemsnitsalder();
                                        Console.WriteLine("");
                                        Console.WriteLine("Gennemsnitsalder: " + gnsAlder + " år");
                                    }

                                    Console.WriteLine("Tryk på en tast for at fortsætte...");
                                    Console.ReadKey();
                                    break;

                                case "3":
                                    // går tilbage til hovedmenuen
                                    adminKoerer = false;
                                    break;

                                default:
                                    // hvis man taster noget forkert
                                    Console.WriteLine("Ugyldigt valg. Prøv igen.");
                                    Console.WriteLine("Tryk på en tast for at fortsætte...");
                                    Console.ReadKey();
                                    break;
                            }
                        }
                    }
                    else
                    {
                        // forkert password
                        Console.WriteLine("Fejl: Forkert password.");
                        Console.WriteLine("Tryk på en tast for at fortsætte...");
                        Console.ReadKey();
                    }
                    break;

                case "3":
                    // sætter koerer til false så while-løkken stopper
                    koerer = false;
                    break;

                default:
                    // hvis man taster noget der ikke er 1, 2 eller 3
                    Console.WriteLine("Ugyldigt valg. Prøv igen.");
                    Console.WriteLine("Tryk på en tast for at fortsætte...");
                    Console.ReadKey();
                    break;
            }
        }

        // programmet slutter her når while-løkken er stoppet
        Console.Clear();
        Console.WriteLine("Tak fordi du brugte CMIS Nyhedsbrev.");
        Console.WriteLine("Programmet afsluttes...");
    }

    // maks antal brugere vi kan have i arrayet
    static int maksAntal = 100;

    // tæller hvor mange brugere der er lige nu
    static int antalBrugere = 0;

    // arrays til at gemme data om hver bruger
    static string[] telefonnumre = new string[maksAntal];
    static string[] fornavne = new string[maksAntal];
    static string[] efternavne = new string[maksAntal];
    static int[] aldre = new int[maksAntal];
    static string[] adresser = new string[maksAntal];
    static string[] postnumre = new string[maksAntal];
    static string[] byer = new string[maksAntal];
    static int[] frekvenser = new int[maksAntal]; // 12 = hver måned, 4 = hver 3. måned, 1 = årligt

    // password man skal bruge for at komme ind i admin
    static string adminPassword = "cmis2026";

    // denne funktion beregner gennemsnitsalderen af alle brugere
    // den returnerer en double værdi
    static double BeregnGennemsnitsalder()
    {
        // lægger alle aldre sammen
        double sum = 0;
        for (int i = 0; i < antalBrugere; i++)
        {
            sum = sum + aldre[i];
        }
        // dividerer med antal brugere for at få gennemsnittet
        return sum / antalBrugere;
    }
}
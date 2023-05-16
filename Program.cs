using System;

class Program
{
    static bool IsValidSequence(string halfDNASequence)
    {
        foreach (char nucleotide in halfDNASequence)
        {
            if (!"ATCG".Contains(nucleotide))
            {
                return false;
            }
        }
        return true;
    }

    static string ReplicateSeqeunce(string halfDNASequence)
    {
        string result = "";
        foreach (char nucleotide in halfDNASequence)
        {
            result += "TAGC"["ATCG".IndexOf(nucleotide)];
        }
        return result;
    }

    static void Main()
    {
        bool runProgram = true;
        while (runProgram)
        {
            Console.Write("Enter half DNA sequence: ");
            string inputSequence = Console.ReadLine();

            if (IsValidSequence(inputSequence))
            {
                Console.WriteLine("Current half DNA sequence: " + inputSequence);
                Console.Write("Do you want to replicate it? (Y/N): ");
                char choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (char.ToUpper(choice) == 'Y')
                {
                    string replicatedSequence = ReplicateSeqeunce(inputSequence);
                    Console.WriteLine("Replicated half DNA sequence: " + replicatedSequence);
                }
                else if (char.ToUpper(choice) == 'N')
                {
                    Console.WriteLine("Skipping DNA replication.");
                }
                else
                {
                    Console.WriteLine("Please input Y or N.");
                }
            }
            else
            {
                Console.WriteLine("That half DNA sequence is invalid.");
            }

            Console.Write("Do you want to process another sequence? (Y/N): ");
            char continueChoice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (char.ToUpper(continueChoice) == 'N')
            {
                runProgram = false;
            }
            else if (char.ToUpper(continueChoice) != 'Y')
            {
                Console.WriteLine("Please input Y or N.");
            }

            Console.WriteLine();
        }
    }
}

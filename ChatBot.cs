using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgPOE
{
    class ChatBot
    {
        public void Run()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(
                            "🌐 Welcome to your personal Cybersecurity Awareness Bot — your digital defender in a world full of cyber threats! 🔐\n" +
                            "I am loaded with knowledge on phishing, malware, ransomware, password safety, and more. Think of me as your AI sidekick — ready to battle shady links, sketchy emails, and sneaky hackers — one byte at a time.\n" +
                            "Type 'ask me about' to get a menu of topics, or throw your own questions at me like a pro!"
             ); 

            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            // Prompt until valid name entered
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.Write("Please enter your name: ");
                name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Name cannot be empty. Try again.");
                    Console.ResetColor();
                }
            }


            Console.WriteLine($"Nice to meet you, {name}!");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nAsk me a cybersecurity question (type 'ask me about', or 'exit' to quit): ");
                Console.ResetColor();

                string userInput = Console.ReadLine().Trim().ToLower();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Please enter a valid question.");
                    continue;
                }

                if (userInput == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Thanks for visiting! Stay safe online. 👋");
                    Console.ResetColor();
                    break;
                }

                // Get the chatbot's response
                string response = GetResponse(userInput);
                SimulateTyping(response);
            }
        }

        // Returns appropriate response based on user input
        static string GetResponse(string question)
        {
            if (question.Contains("ask me about") || question.Contains("topics"))
            {
                return "You can ask me about:\n" +
                         " 1. Phishing\n" +
                         " 2. Ransomware\n" +
                         " 3. Malware\n" +
                         " 4. Social engineering\n" +
                         " 5. Password safety\n" +
                         " 6. Safe browsing\n" +
                         " 7. What is cybersecurity\n" +
                         " 8. Why is cybersecurity important\n" +
                         " 9. How do I make my passwords strong?\n" +
                         "10. What is a firewall?\n" +
                         "11. How do I know if a website is safe?\n" +
                         "12. What should I do if I get hacked?\n" +
                         "Type the number or name to learn more!";
            }

            // Now check for keywords in the question
            if (question.Contains("phishing"))
                return "Phishing is a scam where attackers trick you into revealing personal information.";

            if (question.Contains("ransomware"))
                return "Ransomware locks your files and demands payment to restore access.";

            if (question.Contains("malware"))
                return "Malware is software designed to harm or exploit your computer.";

            if (question.Contains("social engineering"))
                return "Social engineering tricks people into giving away sensitive information.";

            if (question.Contains("password") && question.Contains("strong"))
                return "Use passwords with at least 12 characters, mixing letters, numbers, and symbols. Avoid using personal info.";

            if (question.Contains("safe browsing") || question.Contains("https") || question.Contains("website is safe"))
                return "Avoid suspicious links and always use HTTPS websites. Look for the padlock icon in the address bar.";

            if (question.Contains("cybersecurity") && question.Contains("what is"))
                return "Cybersecurity is the practice of protecting systems, networks, and programs from digital attacks.";

            if (question.Contains("why") && question.Contains("cybersecurity"))
                return "Cybersecurity is important to protect sensitive data, maintain privacy, and ensure business continuity.";

            if (question.Contains("firewall"))
                return "A firewall is a security system that monitors and controls incoming and outgoing network traffic based on security rules.";

            if (question.Contains("hacked"))
                return "If you get hacked, immediately change your passwords, disconnect from the internet, run a full antivirus scan, and report the incident.";

            if (question.Contains("how are you"))
                return "I'm a bot, so I don't have feelings, but I'm here to help!";

            if (question.Contains("purpose"))
                return "I provide cybersecurity awareness and safety tips.";

            // Default fallback
            return "I didn't quite understand that. Could you rephrase?";
        }

        // Simulates a typing effect when the bot responds
        static void SimulateTyping(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(30); // slight delay for realism
            }
            Console.WriteLine();
        }
    }
}
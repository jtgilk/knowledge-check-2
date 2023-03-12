using System;

namespace KC2
{
    public class Classes
    {
        public virtual bool Fighter { get; set; }
        public virtual bool Barbarian { get; set; }
        public virtual bool Bard { get; set; }
        public virtual bool Wizard { get; set; }

        public Classes()
        {
            Fighter = false;
            Barbarian = false;
            Bard = false;
            Wizard = false;
        }

        public class Player : Classes
        {
            public double Level { get; set; }
            public string PlayerClass { get; set; }
            public string Name { get; set; }

            public Player()
            {
                Console.WriteLine("Who is playing?");
                Name = Console.ReadLine();
                string[] StringArray = { "barbarian", "fighter", "wizard", "bard" };
                TryAgainLevel:
                Console.WriteLine("What level?");
                try
                {
                    Level = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid level, try again");
                    goto TryAgainLevel;
                }
                TryAgain:
                Console.WriteLine("Are they a fighter, barbarian, bard, or wizard?");
                string ClassChoice = Console.ReadLine();
                this.PlayerClass = ClassChoice;
                if (StringArray.Any(s => ClassChoice.Contains(s)))
                {
                    if (ClassChoice.Equals("fighter"))
                    {
                        this.Fighter = true;
                        this.Barbarian= false;
                        this.Bard= false;
                        this.Wizard = false;
                        return;
                    }
                    if (ClassChoice.Equals("barbarian"))
                    {
                        this.Fighter = false;
                        this.Barbarian = true;
                        this.Bard = false;
                        this.Wizard = false;
                        return;
                    }
                    if (ClassChoice.Equals("bard"))
                    {
                        this.Fighter = false;
                        this.Barbarian = false;
                        this.Bard = true;
                        this.Wizard = false;
                        return;
                    }
                    if (ClassChoice.Equals("wizard"))
                    {
                        this.Fighter = false;
                        this.Barbarian = false;
                        this.Bard = false;
                        this.Wizard = true;
                        return;
                    }
                    else
                    {
                        goto BadChoice;
                    }
                }
                else
                {
                    goto BadChoice;
                }
            BadChoice:
                Console.WriteLine("Invalid input, try agian.");
                goto TryAgain;
            }
        }
    }
}
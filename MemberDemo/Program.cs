using System;

namespace MemberDemo
{
    class Member
    {
        protected int annualFee;
        private string name;
        private int memberID;
        private int memberSince;

        public override string ToString()
        {
            return
                "\nName: " + name +
                "\nMember ID: " + memberID +
                "\nMember Since: " + memberSince +
                "\nTotal Annual Fee: " + annualFee;
        }

        public Member()
        {
            Console.WriteLine("Parent Constructor with no parameter");
        }

        public Member(string pName, int pMemberID, int pMemberSince)
        {
            Console.WriteLine("Parent Constructor with 3 parameters");

            name = pName;
            memberID = pMemberID;
            memberSince = pMemberSince;
        }

        // Methode VIRTUAL qui devra etre override dans les classes Child
        public virtual void CalculateAnnualFee()
        {
            annualFee = 0;
        }

    }

    class NormalMember : Member
    {
        // Constructor with 0 parameter
        public NormalMember()
        {
            Console.WriteLine("Child Constructor with no parameter");
        }

        // Constructor with 4 parameters
        public NormalMember(string remarks, string name, int memberID, int memberSince) : base(name, memberID, memberSince)
        {
            Console.WriteLine("Child Constructor with 4 parameters");
            Console.WriteLine("Remarks = {0}", remarks);
        }

        // Pour OVERRIDE the VIRTUAL method in Parent Class
        public override void CalculateAnnualFee()
        {
            annualFee = 100 + 12 * 30;
        }
    }

    class VIPMember : Member
    {
        // Constructor with 3 parameters
        public VIPMember(string name, int memberID, int memberSince) : base(name, memberID, memberSince)
        {
            Console.WriteLine("Child Constructor with 3 parameters");
        }

        public override void CalculateAnnualFee()
        {
            annualFee = 1200;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            // Premiere etape
            /*
            NormalMember mem1 = new NormalMember("Special Rate", "James", 1, 2010);
            VIPMember mem2 = new VIPMember("Andy", 2, 2011);

            mem1.CalculateAnnualFee();
            mem2.CalculateAnnualFee();

            Console.WriteLine(mem1.ToString());
            Console.WriteLine(mem2.ToString());
            */

            // Seconde etape
            Member[] clubMembers = new Member[5];

            clubMembers[0] = new NormalMember("Special Rate", "James", 1, 2010);
            clubMembers[1] = new NormalMember("Normal Rate",  "Andy",  2, 2011);
            clubMembers[2] = new NormalMember("Normal Rate",  "Bill",  3, 2011);
            clubMembers[3] = new VIPMember("Carol",  4, 2012);
            clubMembers[4] = new VIPMember("Evelyn", 5, 2013);


            foreach (Member m in clubMembers)
            {
                m.CalculateAnnualFee();
                Console.WriteLine(m.ToString());
                if (m.GetType() == typeof(VIPMember))
                    Console.WriteLine("Yes, is VIP member.");
                else
                    Console.WriteLine("No, is not VIP, just a fucking bastard Normal member.");
            }
        }
    }
}

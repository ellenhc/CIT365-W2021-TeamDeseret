using MeetingPlanner.Models;
using System;
using System.Linq;

namespace MeetingPlanner.Data
{
    public class DbInitializer
    {
        public static void Initialize(MeetingContext context)
        {
            context.Database.EnsureCreated();

            // Look for any persons
            if (context.Persons.Any())
            {
                return;   // DB has been seeded
            }

            var persons = new Person[]
            {
            new Person{FirstName="Carson",LastName="Alexander"},
            new Person{FirstName="Meredith",LastName="Alonso"},
            new Person{FirstName="Arturo",LastName="Anand"},
            new Person{FirstName="Gytis",LastName="Barzdukas"},
            new Person{FirstName="Yan",LastName="Li"},
            new Person{FirstName="Peggy",LastName="Justice"},
            new Person{FirstName="Lou",LastName="Norman"},
            new Person{FirstName="Laura",LastName="Norman"},
            new Person{FirstName="Nina",LastName="Olivetto"}
            };
            foreach (Person p in persons)
            {
                context.Persons.Add(p);
            }
            context.SaveChanges();

            var meetings = new Meeting[]
            {
            new Meeting{ Presiding = "Bishop John Lukas", Conducting = "Thomas Grant", Date = new DateTime(2021, 4, 11), OpenHymnTitle= "Now Let Us Rejoice",OpenHymnNum= 3, SacramentHymnTitle = "As Now We Take the Sacrament", SacramentHymnNum = 169, ClosingHymnTitle = "Abide with Me!", ClosingHymnNum = 166, OpeningPrayer = "Susan Collins", ClosingPrayer = "Richard Collins"},
            new Meeting{ Presiding = "Bishop John Lukas", Conducting = "Bishop Lukas", Date = new DateTime(2021, 4, 18), OpenHymnTitle= "How Firm a Foundation",OpenHymnNum= 85, SacramentHymnTitle = "We’ll Sing All Hail to Jesus’ Name", SacramentHymnNum = 182, ClosingHymnTitle = "God Be with You Till We Meet Again", ClosingHymnNum = 152, OpeningPrayer = "Collin Ray", ClosingPrayer = "Janice Dean"},
            new Meeting{ Presiding = "Bishop John Lukas", Conducting = "Steven Wright", Date = new DateTime(2021, 4, 25), OpenHymnTitle= "Rejoice, the Lord Is King!",OpenHymnNum= 66, SacramentHymnTitle = "Upon the Cross of Calvary", SacramentHymnNum = 184, ClosingHymnTitle = "Sweet Is the Work", ClosingHymnNum = 147, OpeningPrayer = "Henry Ford", ClosingPrayer = "Mark Splits"}
            };
            foreach (Meeting m in meetings)
            {
                context.Meetings.Add(m);
            }
            context.SaveChanges();

            var assignments = new Assignment[]
            {
            new Assignment{PersonID=1,MeetingID=1, Type=AssignmentType.Talk, Title = "Be One With The Prophet", ShowOrder = 10},
            new Assignment{PersonID=2,MeetingID=1, Type=AssignmentType.Talk, Title = "The Gospel Makes People Happy", ShowOrder = 11},
            new Assignment{PersonID=3,MeetingID=2, Type=AssignmentType.Talk, Title = "Worthy of All Acceptation", ShowOrder = 10},
            new Assignment{PersonID=4,MeetingID=2, Type=AssignmentType.Talk, Title = "Response to the Call", ShowOrder = 11},
            new Assignment{PersonID=5,MeetingID=2, Type=AssignmentType.Song, Title = "Tell Me the Stories of Jesus", AddInfo = "Primary Songbook 57", ShowOrder = 12},
            new Assignment{PersonID=6,MeetingID=2, Type=AssignmentType.Talk, Title = "True Religion", ShowOrder = 13},
            new Assignment{PersonID=7,MeetingID=3, Type=AssignmentType.Blessing, Title = "Baby Blessing", AddInfo = "Norman Family Baby Twin Boy", ShowOrder = 1},
            new Assignment{PersonID=7,MeetingID=3, Type=AssignmentType.Blessing, Title = "Baby Blessing", AddInfo = "Norman Family Baby Twin Girl", ShowOrder = 2},
            new Assignment{PersonID=8,MeetingID=3, Type=AssignmentType.Talk, Title = "Behold Your Little Ones", ShowOrder = 10},
            new Assignment{PersonID=9,MeetingID=3, Type=AssignmentType.Talk, Title = "Help Thou Your Neighbor", ShowOrder = 11}
            };
            foreach (Assignment a in assignments)
            {
                context.Assignments.Add(a);
            }
            context.SaveChanges();
        }
    }
}


using System.Data.Entity;

namespace ScoutCheersWeb.Models
{
    public class CheersInitializer : DropCreateDatabaseAlways<CheersContext>
    {
        protected override void Seed(CheersContext context)
        {
            context.Cheers.Add(new Cheer { Name = "Almost", Description = "With hands far apart, bring them rapidly together but miss just before meeting each other." });
            context.Cheers.Add(new Cheer { Name = "Archery", Description = "Shoot arrow and shout \"BULLS EYE.\"" });
            context.Cheers.Add(new Cheer { Name = "Avon Lady Cheer", Description = "\"Dinnnnng! Donnnng!\"" });
            context.Cheers.Add(new Cheer { Name = "Baseball Cheer", Description = "\"Back, Back, Back, It's out of here! Homerun!\"" });
            context.Cheers.Add(new Cheer { Name = "Bee Cheer", Description = "\"Bzzzzzzzz, Bzzzzzzz, OUCH!\"" });
            context.Cheers.Add(new Cheer { Name = "Beehive Cheer", Description = "Buzz gets louder or softer when leader's hand is high or low." });
            context.Cheers.Add(new Cheer { Name = "Bear Cheer", Description = "\"Grrrrrr!\"" });
            context.Cheers.Add(new Cheer { Name = "Big Hand", Description = "Leader says, \"let's give them a big hand\" everybody holds up one hand, palm out." });
            context.Cheers.Add(new Cheer { Name = "Blastoff", Description = "\"10 9 8 7 6 5 4 3 2 1 BLASTOFF!\"" });
            context.Cheers.Add(new Cheer { Name = "Canned Cheer", Description = "Leader opens and closes imaginary can, to start and stop cheering." });
            context.Cheers.Add(new Cheer { Name = "Canned Laughter", Description = "Leader opens and closes imaginary can, to start and stop laughter." });
            context.Cheers.Add(new Cheer { Name = "Cat cheer", Description = "\"MeeeeOOOOW!!!\"" });
            context.Cheers.Add(new Cheer { Name = "Clam", Description = "Fold hands together, interlocking fingers. Make noise by pressing palms together." });
            context.Cheers.Add(new Cheer { Name = "Class A", Description = "Clap in this rhythm: 1-2-3-4, 1-2, 1-2, 1-2-3-4, 1-2, 1-2, 1-2-3-4...(pause)..One big clap." });
            context.Cheers.Add(new Cheer { Name = "Cow Cheer", Description = "\"MOOOOO!!!\"" });
            context.Cheers.Add(new Cheer { Name = "Cowboy Cheer", Description = "Twirl lasso. Yell: \"Yeeee Haaaw!!!\"" });
            context.Cheers.Add(new Cheer { Name = "Coyote Cheer", Description = "\"\"YIP, YIP, YIPEEEE!!!!!\"!!!\"" });
            context.Cheers.Add(new Cheer { Name = "Doctor's Cheer", Description = "Open up, tongs out, everyone say \"Aaaaaah!\"" });
            context.Cheers.Add(new Cheer { Name = "Dog Cheer", Description = "\"Woof, woof, woof!\"" });
            context.Cheers.Add(new Cheer { Name = "Drum Roll", Description = "Pat knees soft then loud, then one last pat." });
            context.Cheers.Add(new Cheer { Name = "Duck Call", Description = "Make a duck call by making a circle with thumb & index finger. Blow like a trumpet." });
            context.Cheers.Add(new Cheer { Name = "Easy Duck Call", Description = "Make a duck call as above but instead yell, \"Here duck! Here duck!\"" });
            context.Cheers.Add(new Cheer { Name = "Dynamite", Description = "Light fuse, \"Sssssssssssssss, BOOM!\"" });
            context.Cheers.Add(new Cheer { Name = "Eskimo", Description = "Hold your shoulders, shiver, say \"Brrrr.\"" });
            context.Cheers.Add(new Cheer { Name = "Ferris Wheel", Description = "Like Round of Applause but also say \"Ooooh\" on the way up, \"Aaaah\" on the way down." });
            context.Cheers.Add(new Cheer { Name = "Fireworks Cheer", Description = "Look up at the ceiling and say \"OOOOOH!\" \"AHHHHH!\"" });
            context.Cheers.Add(new Cheer { Name = "Food Cheer", Description = "\"Yuuuummm!\"" });
            context.Cheers.Add(new Cheer { Name = "Football", Description = "Signal a touchdown and yell \"Touchdown!\"" });
            context.Cheers.Add(new Cheer { Name = "Fred Flintstone Cheer", Description = "\"Yabba-dabba-doo\"." });
            context.Cheers.Add(new Cheer { Name = "Frog Cheer", Description = "Crouch down. Jump Up.\"Ribbit! Ribbit!\"" });
            context.Cheers.Add(new Cheer { Name = "Ghost, fast", Description = "\"Boo!\"" });
            context.Cheers.Add(new Cheer { Name = "Ghost, scary", Description = "Stand, hands up: \"Whooooooooo.\"" });
            context.Cheers.Add(new Cheer { Name = "Good Turn", Description = "Stand, clap as you turn in one full circle." });
            context.Cheers.Add(new Cheer { Name = "Homerun cheer", Description = "\"Back…Back…Back…HOMERUN!" });
            context.Cheers.Add(new Cheer { Name = "Ice cube cheer", Description = "\"COOOOOOOOOL!\"" });
            context.Cheers.Add(new Cheer { Name = "Jet flying", Description = "\"ZOOOOOM\"" });
            context.Cheers.Add(new Cheer { Name = "Jet flying backwards", Description = "\"MOOOOOZ!\"" });
            context.Cheers.Add(new Cheer { Name = "Ketchup Bottle Cheer", Description = "Hold bottle in one hand and slap with other hand to get ketchup out." });
            context.Cheers.Add(new Cheer { Name = "Magician's Cheer", Description = "\"Taaa Daaa!\"" });
            context.Cheers.Add(new Cheer { Name = "Mosquito Cheer", Description = "Slap face, neck, shoulders, etc." });
            context.Cheers.Add(new Cheer { Name = "One hand cheer", Description = "Leader: \"What is the sound of one hand clapping?\" Everyone claps one hand." });
            context.Cheers.Add(new Cheer { Name = "Photographer's cheer", Description = "Pretend to take their picture. \"Everyone smile. Say Cheeese!\"" });
            context.Cheers.Add(new Cheer { Name = "Pig Cheer", Description = "Suueeee, Pig! Pig! Pig!" });
            context.Cheers.Add(new Cheer { Name = "Politician's Cheer", Description = "Pat yourself on the back." });
            context.Cheers.Add(new Cheer { Name = "Popcorn Cheer", Description = "\"Pop! . . . Pop! . . Pop! Pop! Pop! Pop! Pop! Pop! Pop! Pop! Pop!\"" });
            context.Cheers.Add(new Cheer { Name = "Relay Clap", Description = "First person claps second person's hand and then relay it on through all of the Cubs." });
            context.Cheers.Add(new Cheer { Name = "Roller Coaster Cheer", Description = "Hold onto bar, tip back, say \"Click,click, click, click, click, WHEEEEEE!\"" });
            context.Cheers.Add(new Cheer { Name = "Round of Applause", Description = "While clapping hands, move them around in a circle in front of you." });
            context.Cheers.Add(new Cheer { Name = "Seal of Approval", Description = "Put your arms straight out together. Clap flippers and say \"Ort, Ort, Ort\"" });
            context.Cheers.Add(new Cheer { Name = "Silent Yell", Description = "Everyone stands and open their mouths and screams without making any sound." });
            context.Cheers.Add(new Cheer { Name = "Six Shooter Cheer", Description = "Point imaginary gun in air and say \"BANG!\" six times." });
            context.Cheers.Add(new Cheer { Name = "Supersonic Cheer", Description = "Wave arms; pretend to cheer. Sit down wait a moment, then make sounds." });
            context.Cheers.Add(new Cheer { Name = "Surgeon's Cheer", Description = "Right Side of room: \"Scalpel!\" Left Side: \"Sponge!\" Back: \"Oops!\" Go faster & faster." });
            context.Cheers.Add(new Cheer { Name = "Theater Cheer", Description = "\"Bravo! Bravo! Bravo!\"" });
            context.Cheers.Add(new Cheer { Name = "Thunderstorm Cheer", Description = "Pat knees soft them loud, then yell \"Booom\"" });
            context.Cheers.Add(new Cheer { Name = "Tiger call", Description = "Quietly: \"Here, kitty, kitty, kitty.\" \"Here, kitty, kitty, kitty.\"" });
            context.Cheers.Add(new Cheer { Name = "Tony the Tiger cheer", Description = "\"They're Greeeeeat!\"" });
            context.Cheers.Add(new Cheer { Name = "Water Sprinkler", Description = "Move outstretched arm in a circle: \"Choo, Choo, Choo, etc.\" Swing back \"Whee!\"" });
            context.Cheers.Add(new Cheer { Name = "Watermelon", Description = "Hold a big slice in both hands, suck up from one end to the other, spit out the seeds." });
            context.Cheers.Add(new Cheer { Name = "Wave", Description = "As done at sports, stand, raise hand and cheer then sit as a wave around the room." });
            context.Cheers.Add(new Cheer { Name = "Wave of applause", Description = "Lie Wave but clap on your turn." });
            context.Cheers.Add(new Cheer { Name = "Wolf Cheer", Description = "Wolf howl: \"Wooooooooooooooooooo!\"" });

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
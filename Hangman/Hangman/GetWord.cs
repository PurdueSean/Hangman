using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class GetWord
    {
        public static string WordGetter()
        {
            // This string contains 250 unique words pulled from a list
            // of the most common six letter words in the English language.
            // The program sorts them, for no real reason to be honest, and
            // one is selected as the secret word. Having 250 unique words
            // allows for a variety in the games before a word is repeated.
            // This should allow the user to not memorize the word list which
            // would make the game rather boring.
            // If updates to this project were made I would consider embedding a database
            // and inserting these words as the base and allow users to add new six letter words
            // for customization. 
            string unsortedwords = "Apples,Cycles,Coffee,Cached,Camera,Calves,Cardio,Cavity,Center," +
                "Cheeks,Ceased,Baller,Buddha,Browns,Bridal,Cabled,Ampere,Ampule,Anchor,Abduct,Aboard,Albeit," +
                "Alined,Allure,Altars,Diesel,Devour,Desire,Digest,Diving,Doozie,Donkey,Drains,Dozens,Drones,Double," +
                "Driven,Drunks,Dreamt,Drafts,Fizzle,Fletch,Fibers,Flings,Gambit,Gibbon,Gluten,Gifted,Giving,Garage,Helmet," +
                "Heater,Hemmed,Height,Heresy,Herder,Higher,Hookah,Hungry,Ideals,Iconic,Icebox,Icicle,Hyphen,Ignite,Impede," +
                "Impose,Injury,Jetway,Jingle,Jewels,Jester,Jokers,Judged,Jogger,Juicer,Jargon,Jumped,Kennel,Keypad,Kindle," +
                "Kisses,Ladles,Legend,Lactic,Larvas,Lassos,Lather,Latino,Lavish,Leeway,Lowest,Lunacy,Making,Mainly,Mammal," +
                "Manure,Market,Mascot,Marlin,Mayors,Masons,Marrow,Mature,Maxims,Meadow,Mayday,Medium,Nausea,Nearer,Narrow," +
                "Nutmeg,Nurses,Octave,Oceans,Ocular,Object,Number,Novice,Nudity,Nozzle,Octane,Outlaw,Outlet,Panama,Paints," +
                "Paired,Pamper,Pagoda,Pacify,Pacing,Parsed,Parrot,Pastor,Pastry,Pieces,Plants,Purist,Quaker,Queued,Quokka," +
                "Quarts,Rabbit,Rabbis,Racing,Rabble,Racers,Raises,Raisin,Ramble,Rascal,Rating,Raving,Ration,Ratios,Ravage," +
                "Rebels,Rebuke,Record,Recess,Reward,Roasts,Safari,Sailer,Saliva,Salmon,Salary,Salves,Sanity,Satire,Sauces," +
                "Saving,Scarab,Scared,Schism,Scoops,Scones,Scream,Seeker,Severe,Sewing,Shamed,Sifter,Silver,Snared,Sneaky," +
                "Snails,Soften,Salute,Solved,String,Stride,Strife,Studio,Stuffy,Sunken,Swamps,Tamale,Timbre,Teaser,Temple," +
                "Teapot,Teflon,Tights,Tongue,Triple,Tundra,Undead,Unpaid,Unsafe,Usable,Ushers,Useful,Uptime,Vacant,Vacuum," +
                "Vanity,Vaults,Voided,Visual,Voices,Voters,Voting,Vortex,Wallet,Waffle,Wanted,Warped,Walrus,Warmed,Weaved," +
                "Whaler,Wiggle,Winery,Winner,Worker,Wreaks,Wolves,Yachts,Yearly,Yellow,Youths,Yogurt,Volume,Zeroes,Zombie," +
                "Zoomed,Zinger,Zested";
                List<string> sortedwords = unsortedwords.Split(',').ToList();

            int index = new Random().Next(sortedwords.Count);
            string secretword = sortedwords[index];
            // ToUpper is being used here to turn the secret word
            // into an all uppercase word. This is done for uniformity.
            // It allows for uniformity of the word if all characters
            // are the same case, and it is my opinion that upper 
            // case is the better option. 
            return secretword.ToUpper();
        }

    }
}

public static class Database
{
    public static List<Song> DatabaseSongs = new List<Song> //50 songs, 10+ artists
    {
        new Song("Demons", "Imagine Dragons", 178), 
        new Song("Radioactive", "Imagine Dragons", 186),
        new Song("On Top of the World", "Imagine Dragons", 217),
        new Song("Believer", "Imagine Dragons", 204),
        new Song("Whatever It Takes", "Imagine Dragons", 201),
        new Song("Viva La Vida", "Coldplay", 242),
        new Song("Fix You", "Coldplay", 294),
        new Song("Clocks", "Coldplay", 307),
        new Song("The Scientist", "Coldplay", 309),
        new Song("Paradise", "Coldplay", 278),
        new Song("A Sky Full of Stars", "Coldplay", 268),
        new Song("Beethoven's 5 Secrets", "The Piano Guys", 320),
        new Song("A Thousand Years", "The Piano Guys", 261),
        new Song("Let It Go (Disney)", "The Piano Guys", 246),
        new Song("Story of My Life", "The Piano Guys", 264),
        new Song("Fight Song / Amazing Grace", "The Piano Guys", 283),
        new Song("This Is Me", "The Piano Guys", 204),
        new Song("Counting Stars", "OneRepublic", 257),
        new Song("Secrets", "OneRepublic", 228),
        new Song("Good Life", "OneRepublic", 245),
        new Song("Apologize", "OneRepublic", 225),
        new Song("Say (All I Need)", "OneRepublic", 232),
        new Song("Fireflies", "Owl City", 229),
        new Song("Vanilla Twilight", "Owl City", 223),
        new Song("Good Time", "Owl City & Carly Rae Jepsen", 213),
        new Song("Unwritten", "Natasha Bedingfield", 241),
        new Song("Pocketful of Sunshine", "Natasha Bedingfield", 211),
        new Song("Safe and Sound", "Capital Cities", 192),
        new Song("Home", "Phillip Phillips", 222),
        new Song("Let Her Go", "Passenger", 253),
        new Song("Riptide", "Vance Joy", 204),
        new Song("Somewhere Only We Know", "Keane", 232),
        new Song("Chasing Cars", "Snow Patrol", 267),
        new Song("You Found Me", "The Fray", 266),
        new Song("How to Save a Life", "The Fray", 262),
        new Song("Over My Head (Cable Car)", "The Fray", 221),
        new Song("100 Years", "Five for Fighting", 257),
        new Song("Superman (It's Not Easy)", "Five for Fighting", 238),
        new Song("I'm Yours", "Jason Mraz", 242),
        new Song("Lucky", "Jason Mraz & Colbie Caillat", 230),
        new Song("Banana Pancakes", "Jack Johnson", 198),
        new Song("Better Together", "Jack Johnson", 207),
        new Song("Upside Down", "Jack Johnson", 209),
        new Song("Bubbly", "Colbie Caillat", 217),
        new Song("Realize", "Colbie Caillat", 245),
        new Song("Brighter Than the Sun", "Colbie Caillat", 212),
        new Song("I'm Gonna Be (500 Miles)", "The Proclaimers", 219),
        new Song("Hey, Soul Sister", "Train", 217),
        new Song("Drops of Jupiter", "Train", 263),
        new Song("Drive", "Incubus", 222),

    };
}


/*Song s1 = new Song("Demons", "Imagine Dragons", 178);
Song s2 = new Song("Radioactive", "Imagine Dragons", 186);
Song s3 = new Song("On Top of the World", "Imagine Dragons", 217);
Song s4 = new Song("Believer", "Imagine Dragons", 204);
Song s5 = new Song("Whatever It Takes", "Imagine Dragons", 201);
Song s6 = new Song("Viva La Vida", "Coldplay", 242);
Song s7 = new Song("Fix You", "Coldplay", 294);
Song s8 = new Song("Clocks", "Coldplay", 307);
Song s9 = new Song("The Scientist", "Coldplay", 309);
Song s10 = new Song("Paradise", "Coldplay", 278);
Song s11 = new Song("A Sky Full of Stars", "Coldplay", 268);
Song s12 = new Song("Beethoven's 5 Secrets", "The Piano Guys", 320);
Song s13 = new Song("A Thousand Years", "The Piano Guys", 261);
Song s14 = new Song("Let It Go (Disney)", "The Piano Guys", 246);
Song s15 = new Song("Story of My Life", "The Piano Guys", 264);
Song s16 = new Song("Fight Song / Amazing Grace", "The Piano Guys", 283);
Song s17 = new Song("This Is Me", "The Piano Guys", 204);
Song s18 = new Song("Counting Stars", "OneRepublic", 257);
Song s19 = new Song("Secrets", "OneRepublic", 228);
Song s20 = new Song("Good Life", "OneRepublic", 245);
Song s21 = new Song("Apologize", "OneRepublic", 225);
Song s22 = new Song("Say (All I Need)", "OneRepublic", 232);
Song s23 = new Song("Fireflies", "Owl City", 229);
Song s24 = new Song("Vanilla Twilight", "Owl City", 223);
Song s25 = new Song("Good Time", "Owl City & Carly Rae Jepsen", 213);
Song s26 = new Song("Unwritten", "Natasha Bedingfield", 241);
Song s27 = new Song("Pocketful of Sunshine", "Natasha Bedingfield", 211);
Song s28 = new Song("Safe and Sound", "Capital Cities", 192);
Song s29 = new Song("Home", "Phillip Phillips", 222);
Song s30 = new Song("Let Her Go", "Passenger", 253);
Song s31 = new Song("Riptide", "Vance Joy", 204);
Song s32 = new Song("Somewhere Only We Know", "Keane", 232);
Song s33 = new Song("Chasing Cars", "Snow Patrol", 267);
Song s34 = new Song("You Found Me", "The Fray", 266);
Song s35 = new Song("How to Save a Life", "The Fray", 262);
Song s36 = new Song("Over My Head (Cable Car)", "The Fray", 221);
Song s37 = new Song("100 Years", "Five for Fighting", 257);
Song s38 = new Song("Superman (It's Not Easy)", "Five for Fighting", 238);
Song s39 = new Song("I'm Yours", "Jason Mraz", 242);
Song s40 = new Song("Lucky", "Jason Mraz & Colbie Caillat", 230);
Song s41 = new Song("Banana Pancakes", "Jack Johnson", 198);
Song s42 = new Song("Better Together", "Jack Johnson", 207);
Song s43 = new Song("Upside Down", "Jack Johnson", 209);
Song s44 = new Song("Bubbly", "Colbie Caillat", 217);
Song s45 = new Song("Realize", "Colbie Caillat", 245);
Song s46 = new Song("Brighter Than the Sun", "Colbie Caillat", 212);
Song s47 = new Song("I'm Gonna Be (500 Miles)", "The Proclaimers", 219);
Song s48 = new Song("Hey, Soul Sister", "Train", 217);
Song s49 = new Song("Drops of Jupiter", "Train", 263);
Song s50 = new Song("Drive", "Incubus", 222);
*/
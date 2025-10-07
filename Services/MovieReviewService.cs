using System.ComponentModel;
using BugFreeBroccoli.Models;

namespace BugFreeBroccoli.Services
{
    public class MovieReviewService : IMovieReviewService
    {
        private static readonly List<MovieModel> Movies = new List<MovieModel>
        {
            new(){
                Id=1,
                Title = "Highlander",
                Description = "When the mystical Russell Nash (Christopher Lambert) kills a man in a sword fight in a New York City parking lot, he leaves a sliver of an ancient weapon lodged in a car in the process. After brilliant forensics specialist Brenda Wyatt (Roxanne Hart) recovers evidence of the mysterious weapon, she and her partner, Lt. Frank Moran (Alan North), embark on an investigation Of Nash that will land them in the middle of a dangerous, centuries-old feud between powerful immortals.",
                ImageUrl = "/images/movies/Highlander.png",
                Review = "This was a great movie!",
                Genre = "Fantasy",
                Franchise = "Highlander",
                TrailerUrl = "https://www.youtube.com/embed/4P9f6PDH8oA"
            },
             new(){
                Id=2,
                Title = "Star Wars: The Empire Strikes Back",
                Description = "The adventure continues in this \"Star Wars\" sequel. Luke Skywalker (Mark Hamill), Han Solo (Harrison Ford), Princess Leia (Carrie Fisher) and Chewbacca (Peter Mayhew) face attack by the Imperial forces and its AT-AT walkers on the ice planet Hoth. While Han and Leia escape in the Millennium Falcon, Luke travels to Dagobah in search of Yoda. Only with the Jedi master's help will Luke survive when the dark side of the Force beckons him into the ultimate duel with Darth Vader (David Prowse).",
                ImageUrl = "/images/movies/StarWarsTheEmpireStrikesBack.png",
                Review = "This was a great movie!",
                Genre = "Sci-Fi",
                Franchise = "Star Wars",
                TrailerUrl = "https://www.youtube.com/embed/JNwNXF9Y6kY"
            },
            new(){
                Id=3,
                Title = "Last of the Mohicans",
                Description = "The last members of a dying Native American tribe, the Mohicans -- Uncas (Eric Schweig), his father Chingachgook (Russell Means), and his adopted half-white brother Hawkeye (Daniel Day-Lewis) -- live in peace alongside British colonists. But when the daughters (Madeleine Stowe, Jodhi May) of a British colonel are kidnapped by a traitorous scout, Hawkeye and Uncas must rescue them in the crossfire of a gruesome military conflict of which they wanted no part: the French and Indian War.",
                ImageUrl = "/images/movies/LastOfTheMohicans.png",
                Review = "This was a great movie!",
                Genre = "Historical Drama",
                Franchise = "The Last of the Mohicans",
                TrailerUrl = "https://www.youtube.com/embed/3Zt9vYz8kq8"
            },
            new(){
                Id=4,
                Title = "Star Wars: A New Hope",
                Description = "The Imperial Forces -- under orders from cruel Darth Vader (David Prowse) -- hold Princess Leia (Carrie Fisher) hostage, in their efforts to quell the rebellion against the Galactic Empire. Luke Skywalker (Mark Hamill) and Han Solo (Harrison Ford), captain of the Millennium Falcon, work together with the companionable droid duo R2-D2 (Kenny Baker) and C-3PO (Anthony Daniels) to rescue the beautiful princess, help the Rebel Alliance, and restore freedom and justice to the Galaxy.",
                ImageUrl = "/images/movies/StarWarsANewHope.png",
                Review = "This was a great movie!",
                Genre = "Sci-Fi",
                Franchise = "Star Wars"
            },
            new(){
                Id=5,
                Title = "Road House (1989)",
                Description = "The Double Deuce is the meanest, loudest and rowdiest bar south of the Mason-Dixon Line, and Dalton (Patrick Swayze) has been hired to clean it up. He might not look like much, but the Ph.D.-educated bouncer proves he's more than capable -- busting the heads of troublemakers and turning the roadhouse into a jumping hot-spot. But Dalton's romance with the gorgeous Dr. Clay (Kelly Lynch) puts him on the bad side of cutthroat local big shot Brad Wesley (Ben Gazzara).",
                ImageUrl = "/images/movies/RoadHouse.png",
                Review = "This was a great movie!",
                Genre = "Action",
                Franchise = "Road House"
            },
            new(){
                Id=6,
                Title = "Star Wars: The Force Awakens",
                Description = "Star Wars: The Force Awakens continues the saga 30 years after the fall of the Empire, following the First Order's rise as they hunt for the missing Luke Skywalker, the last Jedi. New heroes Rey, a scavenger, and Finn, a defecting stormtrooper, join the Resistance, led by General Leia Organa, and team up with Han Solo and Chewbacca. The movie culminates in the destruction of the First Order's Starkiller Base, but not before Kylo Ren murders Han Solo. The story ends with Rey finding Luke Skywalker, passing him his old lightsaber on the oceanic planet of Ahch-To.",
                ImageUrl = "/images/movies/StarWarsTheForceAwakens.png",
                Review = "This was a great movie!",
                Genre = "Sci-Fi",
                Franchise = "Star Wars"
            },
            new(){
                Id=7,
                Title = "The Dark Knight",
                Description = "With the help of allies, Lt. Jim Gordon and DA Harvey Dent, Batman is able to keep a tight lid on crime in Gotham City. But when a young criminal calling himself the Joker suddenly throws the town into chaos, the caped crusader begins to tread a fine line between heroism and vigilantism.",
                ImageUrl = "/images/movies/TheDarkKnight.png",
                Review = "This was a great movie!",
                Genre = "Superhero",
                Franchise = "DC Comics"
            },
            new(){
                Id=8,
                Title = "The Fugitive",
                Description = "Wrongfully accused of murdering his wife, Richard Kimble escapes from the law in an attempt to find her killer and clear his name. Pursuing him is a team of U.S. marshals led by Deputy Samuel Gerard, a determined detective who will not rest until Richard is captured. As Richard leads the team through a series of intricate chases, he discovers the secrets behind his wife's death and struggles to expose the killer before it is too late.",
                ImageUrl = "/images/movies/TheFugitive.png",
                Review = "This was a great movie!",
                Genre = "Action",
                Franchise = "The Fugitive"
            },
            new(){
                Id=9,
                Title = "The Shawshank Redemption",
                Description = "Andy Dufresne (Tim Robbins) is sentenced to two consecutive life terms in prison for the murders of his wife and her lover and is sentenced to a tough prison. However, only Andy knows he didn't commit the crimes. While there, he forms a friendship with Red (Morgan Freeman), experiences brutality of prison life, adapts, helps the warden, etc., all in 19 years.",
                ImageUrl = "/images/movies/TheShawshankRedemption.png",
                Review = "This was a great movie!",
                Genre = "Drama",
                Franchise = "The Shawshank Redemption"
            },
            new(){
                Id=10,
                Title = "Top Gun",
                Description = "The Top Gun Naval Fighter Weapons School is where the best of the best train to refine their elite flying skills. When hotshot fighter pilot Maverick (Tom Cruise) is sent to the school, his reckless attitude and cocky demeanor put him at odds with the other pilots, especially the cool and collected Iceman (Val Kilmer). But Maverick isn't only competing to be the top fighter pilot, he's also fighting for the attention of his beautiful flight instructor, Charlotte Blackwood (Kelly McGillis).",
                ImageUrl = "/images/movies/TopGun.png",
                Review = "This was a great movie!",
                Genre = "Military",
                Franchise = "Top Gun"
            },
            new(){
                Id=11,
                Title = "Unforgiven",
                Description = "When prostitute Delilah Fitzgerald (Anna Thomson) is disfigured by a pair of cowboys in Big Whiskey, Wyoming, her fellow brothel workers post a reward for their murder, much to the displeasure of sheriff Little Bill Daggett (Gene Hackman), who doesn't allow vigilantism in his town. Two groups of gunfighters, one led by aging former bandit William Munny (Clint Eastwood), the other by the florid English Bob (Richard Harris), come to collect the reward, clashing with each other and the sheriff.",
                ImageUrl = "/images/movies/Unforgiven.png",
                Review = "This was a great movie!",
                Genre = "Western",
                Franchise = "Unforgiven"
            },
            new(){
                Id=12,
                Title = "Star Wars: Return of the Jedi",
                Description = "Luke Skywalker (Mark Hamill) battles horrible Jabba the Hut and cruel Darth Vader to save his comrades in the Rebel Alliance and triumph over the Galactic Empire. Han Solo (Harrison Ford) and Princess Leia (Carrie Fisher) reaffirm their love and team with Chewbacca, Lando Calrissian (Billy Dee Williams), the Ewoks and the androids C-3PO and R2-D2 to aid in the disruption of the Dark Side and the defeat of the evil emperor.",
                ImageUrl = "/images/movies/StarWarsReturnOfTheJedi.png",
                Review = "This was a great movie!",
                Genre = "Sci-Fi",
                Franchise = "Star Wars"
            },
            new(){
                Id=13,
                Title = "Star Wars: Revenge of the Sith",
                Description = "Revenge of the Sith's plot centers on the final days of the Clone Wars, where Supreme Chancellor Palpatine manipulates Jedi Knight Anakin Skywalker into turning to the dark side, transforming him into Darth Vader. This shift empowers the hidden Sith Lord, Darth Sidious, to execute his plan to eradicate the Jedi and overthrow the Republic, establishing the tyrannical Galactic Empire and completing the Sith's thousand-year plot for galactic rule.",
                ImageUrl = "/images/movies/StarWarsRevengeOfTheSith.png",
                Review = "This was a great movie!",
                Genre = "Sci-Fi",
                Franchise = "Star Wars"
            },
            new(){
                Id=14,
                Title = "Terminator",
                Description = "Disguised as a human, a cyborg assassin known as a Terminator (Arnold Schwarzenegger) travels from 2029 to 1984 to kill Sarah Connor (Linda Hamilton). Sent to protect Sarah is Kyle Reese (Michael Biehn), who divulges the coming of Skynet, an artificial intelligence system that will spark a nuclear holocaust. Sarah is targeted because Skynet knows that her unborn son will lead the fight against them. With the virtually unstoppable Terminator in hot pursuit, she and Kyle attempt to escape.",
                ImageUrl = "/images/movies/Terminator.png",
                Review = "This was a great movie!",
                Genre = "Sci-Fi",
                Franchise = "Terminator"
            },
            new(){
                Id=15,
                Title = "Top Gun: Maverick",
                Description = "After more than 30 years of service as one of the Navy's top aviators, Pete \"Maverick\" Mitchell is where he belongs, pushing the envelope as a courageous test pilot and dodging the advancement in rank that would ground him. Training a detachment of graduates for a special assignment, Maverick must confront the ghosts of his past and his deepest fears, culminating in a mission that demands the ultimate sacrifice from those who choose to fly it.",
                ImageUrl = "/images/movies/TopGunMaverick.png",
                Review = "This was a great movie!",
                Genre = "Military",
                Franchise = "Top Gun"
            },
            new(){
                Id=16,
                Title = "Gladiator",
                Description = "Set in Roman times, the story of a once-powerful general forced to become a common gladiator. The emperor's son is enraged when he is passed over as heir in favour of his father's favourite general. He kills his father and arranges the murder of the general's family, and the general is sold into slavery to be trained as a gladiator - but his subsequent popularity in the arena threatens the throne.",
                ImageUrl = "/images/movies/Gladiator.png",
                Review = "This was a great movie!",
                Genre = "Medieval",
                Franchise = "Gladiator"
            },
            new(){
                Id=17,
                Title = "Inception",
                Description = "Dom Cobb (Leonardo DiCaprio) is a thief with the rare ability to enter people's dreams and steal their secrets from their subconscious. His skill has made him a hot commodity in the world of corporate espionage but has also cost him everything he loves. Cobb gets a chance at redemption when he is offered a seemingly impossible task: Plant an idea in someone's mind. If he succeeds, it will be the perfect crime, but a dangerous enemy anticipates Cobb's every move.",
                ImageUrl = "/images/movies/Inception.png",
                Review = "This was a great movie!",
                Genre = "Sci-Fi",
                Franchise = "Inception"
            },
            new(){
                Id=18,
                Title = "The Matrix",
                Description = "In The Matrix, computer programmer and hacker Neo is contacted by rebels led by Morpheus, who reveals that the reality Neo knows is a computer simulation called the Matrix, a prison for humanity created by intelligent machines after they won a war against humans. Morpheus believes Neo is \"the One,\" a prophesied figure who can manipulate the Matrix's rules and liberate humanity. Neo joins the rebellion, learning to bend the simulated reality and fight against the machines and their powerful programs, known as Agents.  ",
                ImageUrl = "/images/movies/TheMatrix.png",
                Review = "This was a great movie!",
                Genre = "Sci-Fi",
                Franchise = "The Matrix"
            },
            new(){
                Id=19,
                Title = "Pulp Fiction",
                Description = "Vincent Vega (John Travolta) and Jules Winnfield (Samuel L. Jackson) are hitmen with a penchant for philosophical discussions. In this ultra-hip, multi-strand crime movie, their storyline is interwoven with those of their boss, gangster Marsellus Wallace (Ving Rhames) ; his actress wife, Mia (Uma Thurman) ; struggling boxer Butch Coolidge (Bruce Willis) ; master fixer Winston Wolfe (Harvey Keitel) and a nervous pair of armed robbers, Pumpkin (Tim Roth) and Honey Bunny (Amanda Plummer).",
                ImageUrl = "/images/movies/PulpFiction.png",
                Review = "This was a great movie!",
                Genre = "Mob/Gangster",
                Franchise = "Pulp Fiction"
            },
            new(){
                Id=20,
                Title = "Forrest Gump",
                Description = "Slow-witted Forrest Gump (Tom Hanks) has never thought of himself as disadvantaged, and thanks to his supportive mother (Sally Field), he leads anything but a restricted life. Whether dominating on the gridiron as a college football star, fighting in Vietnam or captaining a shrimp boat, Forrest inspires people with his childlike optimism. But one person Forrest cares about most may be the most difficult to save -- his childhood love, the sweet but troubled Jenny (Robin Wright).",
                ImageUrl = "/images/movies/ForrestGump.png",
                Review = "This was a great movie!",
                Genre = "Drama",
                Franchise = "Forrest Gump"
            },
            new(){
                Id=21,
                Title = "Avengers: Endgame",
                Description = "The fourth installment in the Avengers saga is the culmination of 22 interconnected Marvel films and the climax of a journey. The world's heroes finally understand just how fragile reality is, and the sacrifices that must be made to uphold it, in a story of friendship, teamwork and setting aside differences to overcome an impossible obstacle.",
                ImageUrl = "/images/movies/AvengersEndGame.png",
                Review = "This was a great movie!",
                Genre = "Superhero",
                Franchise = "MCU"
            },
            new(){
                Id=22,
                Title = "Captain America: The Winter Soldier",
                Description = "After the cataclysmic events in New York with his fellow Avengers, Steve Rogers, aka Captain America (Chris Evans), lives in the nation's capital as he tries to adjust to modern times. An attack on a S.H.I.E.L.D. colleague throws Rogers into a web of intrigue that places the whole world at risk. Joining forces with the Black Widow (Scarlett Johansson) and a new ally, the Falcon, Rogers struggles to expose an ever-widening conspiracy, but he and his team soon come up against an unexpected enemy.",
                ImageUrl = "/images/movies/CaptainAmericaTheWinterSoldier.png",
                Review = "This was a great movie!",
                Genre = "Superhero",
                Franchise = "MCU"
            },
            new(){
                Id=23,
                Title = "Star Wars: Attack of the Clones",
                Description = "Ten years after the invasion of Naboo, the galaxy is on the brink of civil war. Under the leadership of former Jedi Count Dooku (Christopher Lee), thousands of solar systems threaten to secede from the Galactic Republic. When an assassination attempt is made on Senator Padmé Amidala (Natalie Portman), former Queen of Naboo, Jedi Knight Obi-Wan Kenobi (Ewan McGregor) and his apprentice, Anakin Skywalker (Hayden Christensen), are assigned to protect her. While Obi-Wan investigates, Anakin is assigned to accompany Padmé back to Naboo. As Obi-Wan uncovers a secret clone army being created for the Republic and a mysterious new Sith Lord, Anakin grows closer to Padmé, but is also drawn to the dark side of the Force.",
                ImageUrl = "/images/movies/StarWarsAttackOfTheClones.png",
                Review = "This was a great movie!",
                Genre = "Sci-Fi",
                Franchise = "Star Wars"
            },
            new(){
                Id=24,
                Title = "Star Wars: The Phantom Menace",
                Description = "Obi-Wan Kenobi (Ewan McGregor) is a young apprentice Jedi knight under the tutelage of Qui-Gon Jinn (Liam Neeson) ; Anakin Skywalker (Jake Lloyd), who will later father Luke Skywalker and become known as Darth Vader, is just a 9-year-old boy. When the Trade Federation cuts off all routes to the planet Naboo, Qui-Gon and Obi-Wan are assigned to settle the matter.",
                ImageUrl = "/images/movies/StarWarsThePhantomMenace.png",
                Review = "This was a great movie!",
                Genre = "Sci-Fi",
                Franchise = "Star Wars"
            },
            new(){
                Id=25,
                Title = "Die Hard",
                Description = "NYPD cop John McClane (Bruce Willis) is visiting his estranged wife Holly (Bonnie Bedelia) in Los Angeles on Christmas Eve when, she and her colleagues are taken hostage by a group of highly organized criminals led by the ruthless Hans Gruber (Alan Rickman). With the LAPD and FBI outgunned and outmaneuvered, McClane must rely on his wits and training to save the hostages, including Holly, and stop the criminals' plan to steal $640 million in bearer bonds from the Nakatomi Plaza's vault.",
                ImageUrl = "/images/movies/DieHard.png",
                Review = "This was a great movie!",
                Genre = "Action",
                Franchise = "Die Hard"
            },
            new(){
                Id=26,
                Title = "Jurassic Park: The Lost World",
                Description = "A research team is sent to the second island, Site B, to study the dinosaurs there, while an InGen team approaches with another agenda.",
                ImageUrl = "/images/movies/JurassicParkTheLostWorld.png",
                Review = "This was a great movie!",
                Genre = "Sci-Fi",
                Franchise = "Jurassic Park"
            },
            new(){
                Id=27,
                Title = "Jurassic Park",
                Description = "During a preview tour, a theme park suffers a major power breakdown that allows its cloned dinosaur exhibits to run amok.",
                ImageUrl = "/images/movies/JurassicPark.png",
                Review = "This was a great movie!",
                Genre = "Sci-Fi",
                Franchise = "Jurassic Park"
            },
            new(){
                Id=28,
                Title = "Star Wars: Rogue One",
                Description = "The Rebel Alliance makes a risky move to steal the plans for the Death Star, the Empire's ultimate weapon of destruction.",
                ImageUrl = "/images/movies/StarWarsRogueOne.png",
                Review = "This was a great movie!",
                Genre = "Sci-Fi",
                Franchise = "Star Wars"
            },
            new(){
                Id=29,
                Title = "Star Wars: The Last Jedi",
                Description = "Rey develops her newly discovered abilities with the guidance of Luke Skywalker, who is unsettled by the strength of her powers. Meanwhile, the Resistance prepares to do battle with the First Order.",
                ImageUrl = "/images/movies/StarWarsTheLastJedi.png",
                Review = "This was a great movie!",
                Genre = "Sci-Fi",
                Franchise = "Star Wars"
            },
            new(){
                Id=30,
                Title = "The Dark Knight Rises",
                Description = "Eight years after the Joker's reign of anarchy, Batman, with the help of the enigmatic Catwoman, is forced from his exile to save Gotham City from the brutal guerrilla.",
                ImageUrl = "/images/movies/TheDarkKnightRises.png",
                Review = "This was a great movie!",
                Genre = "Superhero",
                Franchise = "DC Comics"
            },
            new(){
                Id=31,
                Title = "Avengers: Infinity War",
                Description = "The Avengers and their allies must be willing to sacrifice all in an attempt to defeat the powerful Thanos before his blitz of devastation and ruin puts an end to the universe.",
                ImageUrl = "/images/movies/AvengersInfinityWar.png",
                Review = "This was a great movie!",
                Genre = "Superhero",
                Franchise = "MCU"
            },
            new(){
                Id=32,
                Title = "Mad Max: Fury Road",
                Description = "In a post-apocalyptic wasteland, Max teams up with Furiosa to flee from a cult leader and his army in an armored tanker truck, leading to a high-octane road war.",
                ImageUrl = "/images/movies/MadMaxFuryRoad.png",
                Review = "This was a great movie!",
                Genre = "Action",
                Franchise = "Mad Max"
            },
            new(){
                Id=33,
                Title = "Star Wars: The Rise of Skywalker",
                Description = "The surviving members of the resistance face the First Order once again, and the legendary conflict between the Jedi and the Sith reaches its peak bringing the Skywalker saga to its end.",
                ImageUrl = "/images/movies/StarWarsTheRiseOfSkywalker.png",
                Review = "This was a great movie!",
                Genre = "Sci-Fi",
                Franchise = "Star Wars"
            },
            new(){
                Id=34,
                Title = "Avengers: Age of Ultron",
                Description = "When Tony Stark and Bruce Banner try to jump-start a dormant peacekeeping program called Ultron, things go horribly wrong and it's up to Earth's mightiest heroes to stop the villainous Ultron from enacting his terrible plans.",
                ImageUrl = "/images/movies/AvengersAgeOfUltron.png",
                Review = "This was a great movie!",
                Genre = "Superhero",
                Franchise = "MCU"
            },
            new(){
                Id=35,
                Title = "The Lord of the Rings: The Return of the King",
                Description = "Gandalf and Aragorn lead the World into war against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
                ImageUrl = "/images/movies/TheLordOfTheRingsTheReturnOfTheKing.png",
                Review = "This was a great movie!",
                Genre = "Fantasy",
                Franchise = "The Lord of the Rings"
            },
            new(){
                Id=36,
                Title = "Hobbit: An Unexpected Journey",
                Description = "A reluctant hobbit, Bilbo Baggins, sets out to the Lonely Mountain with a spirited group of dwarves to reclaim their mountain home - and the gold within it - from the dragon Smaug.",
                ImageUrl = "/images/movies/HobbitAnUnexpectedJourney.png",
                Review = "This was a great movie!",
                Genre = "Fantasy",
                Franchise = "The Lord of the Rings"
            },
            new(){
                Id=37,
                Title = "The Lord of the Rings: The Two Towers",
                Description = "While Frodo and Sam edge closer to Mordor with the help of the shifty Gollum, the divided fellowship makes a stand against Sauron's new ally, Saruman, and his hordes of Isengard.",
                ImageUrl = "/images/movies/TheLordOfTheRingsTheTwoTowers.png",
                Review = "This was a great movie!",
                Genre = "Fantasy",
                Franchise = "The Lord of the Rings"
            },
            new(){
                Id=38,
                Title = "The Lord of the Rings: The Fellowship of the Ring",
                Description = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.",
                ImageUrl = "/images/movies/TheLordOfTheRingsTheFellowshipOfTheRing.png",
                Review = "This was a great movie!",
                Genre = "Fantasy",
                Franchise = "The Lord of the Rings"
            },
            new(){
                Id=39,
                Title = "Hobbit: The Desolation of Smaug",
                Description = "The Dwarves, Bilbo and Gandalf have successfully escaped the Misty Mountains, but their journey to the Lonely Mountain is far from over. They must evade a band of hungry Orcs, outwit giant Spiders and navigate the dark and dangerous Mirkwood Forest. Meanwhile, the dragon Smaug has awoken and is wreaking havoc across Laketown. Can the company survive these perils to reach their destination?",
                ImageUrl = "/images/movies/HobbitTheDesolationOfSmaug.png",
                Review = "This was a great movie!",
                Genre = "Fantasy",
                Franchise = "The Lord of the Rings"
            },
            new(){
                Id=40,
                Title = "Hobbit: The Battle of the Five Armies",
                Description = "Bilbo and the Company of Dwarves arrive at the Lonely Mountain to find Smaug has destroyed Laketown. After slaying the dragon, Thorin must decide how to share the mountain's vast treasure, but his greed drives him to madness. As armies converge on the mountain to claim their share, Bilbo must choose between his own safety and the lives of his friends.",
                ImageUrl = "/images/movies/HobbitTheBattleOfTheFiveArmies.png",
                Review = "This was a great movie!",
                Genre = "Fantasy",
                Franchise = "The Lord of the Rings"
            },
            new(){
                Id=41,
                Title = "Jurassic World",
                Description = "A new theme park, built on the original site of Jurassic Park, creates a genetically modified hybrid dinosaur, the Indominus rex, which escapes containment and goes on a killing spree. Owen Grady, a Velociraptor trainer, and Claire Dearing, the park's operations manager, must work together to stop the Indominus and save the remaining dinosaurs.",
                ImageUrl = "/images/movies/JurassicWorld.png",
                Review = "This was a great movie!",
                Genre = "Sci-Fi",
                Franchise = "Jurassic Park"
            },
            new(){
                Id=42,
                Title = "Jurassic World: Fallen Kingdom",
                Description = "Three years after the demise of Jurassic World, a volcanic eruption threatens the remaining dinosaurs on Isla Nublar. Claire Dearing, now a dinosaur-rights activist, recruits Owen Grady to help save the creatures from extinction. However, they soon discover that a mercenary team has sinister plans for the dinosaurs, leading to a thrilling adventure to protect them from exploitation.",
                ImageUrl = "/images/movies/JurassicWorldFallenKingdom.png",
                Review = "This was a great movie!",
                Genre = "Sci-Fi",
                Franchise = "Jurassic Park"
            },
            new(){
                Id=43,
                Title = "Jurassic World: Dominion",
                Description = "Four years after the destruction of Isla Nublar, dinosaurs now live and hunt alongside humans all over the world. This fragile balance will reshape the future and determine, once and for all, whether human beings are to remain the apex predators on a planet they now share with history's most fearsome creatures.",
                ImageUrl = "/images/movies/JurassicWorldDominion.png",
                Review = "This was a great movie!",
                Genre = "Sci-Fi",
                Franchise = "Jurassic Park"
            },
            new(){
                Id=44,
                Title = "Avengers",
                Description = "When an unexpected enemy emerges and threatens global safety and security, Nick Fury, director of the international peacekeeping agency known as S.H.I.E.L.D., finds himself in need of a team to pull the world back from the brink of disaster. Spanning the globe, a daring recruitment effort begins.",
                ImageUrl = "/images/movies/Avengers.png",
                Review = "This was a great movie!",
                Genre = "Superhero",
                Franchise = "MCU"
            },
            new(){
                Id=45,
                Title = "Jurassic Park III",
                Description = "Dr. Alan Grant is persuaded to join a couple on a research expedition to the second island, Site B, but the plane crashes, stranding them on the island. As they search for a way off the island, they encounter various dinosaurs, including the deadly Spinosaurus, and must use their wits and skills to survive.",
                ImageUrl = "/images/movies/JurassicParkIII.png",
                Review = "This was a great movie!",
                Genre = "Sci-Fi",
                Franchise = "Jurassic Park"
            },
            new(){
                Id=46,
                Title = "Avengers: Secret Wars",
                Description = "Earth's mightiest heroes are transported to a distant planet to battle against an array of villains in a fight for survival and the fate of the universe.",
                ImageUrl = "/images/movies/AvengersSecretWars.png",
                Review = "This was a great movie!",
                Genre = "Superhero",
                Franchise = "MCU"
            },
            new(){
                Id=47,
                Title = "Avatar",
                Description = "On the lush alien world of Pandora live the Na'vi, beings who appear primitive but are highly evolved. Because the planet's environment is poisonous, human/Na'vi hybrids, called Avatars, must link to human minds to allow for free movement on Pandora. Jake Sully (Sam Worthington), a paralyzed former Marine, becomes mobile again through one such Avatar and falls in love with Neytiri (Zoe Saldana), a Na'vi princess. But when corporate greed threatens the peace of Pandora, Jake must choose sides.",
                ImageUrl = "/images/movies/Avatar.png",
                Review = "This was a great movie! It had great visual effects and an engaging story. Fans of sci-fi and adventure genres will likely enjoy this film. The world-building and special effects are particularly impressive.",
                Genre = "Sci-Fi",
                Franchise = "Avatar"
            },
            new(){
                Id=48,
                Title = "Avatar: The Way of Water",
                Description = "Set more than a decade after the events of the first film, \"Avatar: The Way of Water\" follows Jake Sully and Neytiri as they navigate the challenges of family life and the threats posed by renewed human aggression on Pandora. The film explores new regions of Pandora, particularly its vast oceans, introducing new Na'vi clans and marine creatures. As the Sully family faces danger, they must unite with other Na'vi tribes to protect their home and way of life.",
                ImageUrl = "/images/movies/AvatarTheWayOfWater.png",
                Review = "This movie was okay but not as good as the first Avatar. The visual effects were stunning, especially the underwater scenes, but the plot felt a bit weak and predictable. Overall, it was an enjoyable watch for fans of the franchise.",
                Genre = "Sci-Fi",
                Franchise = "Avatar"
            },
            new(){
                Id=49,
                Title = "Captain America: Civil War",
                Description = "Political pressure mounts to install a system of accountability when the actions of the Avengers lead to collateral damage. The new status quo deeply divides members of the team. Captain America (Chris Evans) believes superheroes should remain free to defend humanity without government interference. Iron Man (Robert Downey Jr.) sharply disagrees and supports oversight. As the debate escalates into an all-out feud, Black Widow (Scarlett Johansson) and Hawkeye (Jeremy Renner) must pick a side.",
                ImageUrl = "/images/movies/TheAvengersCivilWar.png",
                Review = "This was a great movie!",
                Genre = "Superhero",
                Franchise = "MCU"
            },
            new(){
                Id=50,
                Title = "Alien (1979)",
                ReleaseDate = new DateTime(1979, 5, 25),
                Description = "During its return to Earth, the commercial spaceship Nostromo intercepts a distress signal from a nearby moon. The ship's crew, awakened from stasis, lands on the moon and discovers a derelict alien spacecraft. Inside, they find a chamber containing numerous eggs. When one of the eggs hatches, a creature attaches itself to a crew member's face. The crew member is brought back to the Nostromo, where the creature eventually detaches and dies. However, a more dangerous alien organism later emerges from the crew member's chest, leading to a deadly game of cat and mouse as the crew tries to survive against the hostile alien.",
                ImageUrl = "/images/movies/Alien.png",
                Review = "This was a great movie!",
                Genre = "Sci-Fi",
                Franchise = "Alien",
                TrailerUrl = "https://www.youtube.com/watch?v=/LjLamj-b0I8"
            },
            new(){
                Id=51,
                Title = "https://www.youtube.com/watch?v=I1W4b1qzSyA",
                ReleaseDate = new DateTime(1986, 7, 18),
                Description = "Ellen Ripley is rescued after drifting in space for 57 years. She learns that the planet where her crew first encountered the alien has been colonized, but contact has been lost. Accompanied by a unit of marines, Ripley returns to the planet to investigate. They discover that the colonists have been wiped out by a hive of aliens. The marines engage in a fierce battle with the aliens, and Ripley must confront her fears and use her wits to survive and protect a girl named Newt, the sole survivor of the colony.",
                ImageUrl = "/images/movies/Aliens.png",
                Review = "This was a great movie!",
                Genre = "Sci-Fi",
                Franchise = "Alien",
                TrailerUrl = "https://www.youtube.com/watch?v=y5rAL5PPaSU?si=c4ViebdOLz-j9lS1"
            },
            new(){
                Id=52,
                Title = "Alien 3 (1992)",
                ReleaseDate = new DateTime(1992, 5, 22),
                Description = "After escaping the alien-infested planet, Ellen Ripley crash-lands on a prison planet inhabited by prisons and guards. She discovers that an alien has also survived the crash and is now loose on the planet. As the alien begins to hunt down the inmates, Ripley must find a way to stop it while dealing with the harsh conditions of the prison and her own inner demons. The film explores themes of sacrifice, redemption, and the struggle for survival in a hostile environment.",
                ImageUrl = "/images/movies/Alien3.png",
                Review = "This was a great movie!",
                Genre = "Sci-Fi",
                Franchise = "Alien",
                TrailerUrl = "https://www.youtube.com/watch?v=KUTaNMJJBa8?si=dlqpI87dK16_ggxJ"
            },
            new(){
                Id=53,
                Title = "Alien: Resurrection (1997)",
                ReleaseDate = new DateTime(1997, 11, 26),
                Description = "Two hundred years after her death, Ellen Ripley is cloned and revived by a group of scientists aboard a spaceship. However, the cloning process also inadvertently brings back the alien queen that was inside her. As the aliens begin to wreak havoc on the ship, Ripley must team up with a group of mercenaries to stop the aliens and prevent them from reaching Earth. The film explores themes of identity, humanity, and the consequences of playing god.",
                ImageUrl = "/images/movies/AlienResurrection.png",
                Review = "This was a great movie!",
                Genre = "Sci-Fi",
                Franchise = "Alien",
                TrailerUrl = "https://www.youtube.com/watch?v=53If-aOy58A?si=l7f_iGnCoaQVHOaK"
            },
            new(){
                Id=54,
                Title = "Prometheus",
                ReleaseDate = new DateTime(2012, 6, 8),
                Description = "A team of explorers embarks on a journey to a distant moon, following a star map discovered among the remnants of several ancient Earth cultures. They hope to find the origins of humanity, but what they discover is far more terrifying. The crew encounters a hostile alien species and uncovers a conspiracy that threatens their survival. The film explores themes of creation, faith, and the search for meaning in the universe.",
                ImageUrl = "/images/movies/Prometheus.png",
                Review = "This was a great movie!",
                Genre = "Sci-Fi",
                Franchise = "Alien",
                TrailerUrl = "https://www.youtube.com/watch?v=0eH3jkB3kZo?si=1mX4mY6JYk1fY6mE"
            },
            new(){
                Id=55,
                Title = "Alien: Covenant",
                ReleaseDate = new DateTime(2017, 5, 19),
                Description = "The crew of the colony ship Covenant, bound for a remote planet on the far side of the galaxy, discovers what they think is an uncharted paradise. However, it soon becomes clear that the planet is not as idyllic as it seems. The crew encounters a deadly alien species and must fight for survival while uncovering the dark secrets of their mission. The film serves as a sequel to Prometheus and explores themes of creation, evolution, and the consequences of playing god.",
                ImageUrl = "/images/movies/AlienCovenant.png",
                Review = "Overall a solid entry in the Alien franchise. While it may not reach the heights of the original films, it offers a visually stunning and suspenseful experience that expands the lore of the series. Fans of the franchise will appreciate the connections to previous films and the exploration of new themes. A few plot holes and character decisions may leave some viewers wanting more depth, but the film's action and horror elements are well-executed. Worth a watch for sci-fi and horror enthusiasts.",
                Genre = "Sci-Fi",
                Franchise = "Alien",
                TrailerUrl = "https://www.youtube.com/watch?v=9uZh0jiA1pE?si=vTo0nWyAZaCjntoo"
            },
            new(){
                Id=56,
                Title = "The Predator (2018)",
                ReleaseDate = new DateTime(2018, 9, 14),
                Description = "When a young warrior accidentally triggers the return of the Predator to Earth, only a ragtag crew of ex-soldiers and a disgruntled science teacher can prevent the end of the human species. As the Predators begin to hunt them down, the group must use their skills and ingenuity to survive and stop the alien threat once and for all. The film combines action, horror, and humor, while exploring themes of survival, teamwork, and the consequences of advanced technology.",
                ImageUrl = "/images/movies/ThePredator.png",
                Review = "This was a great movie!",
                Genre = "Sci-Fi",
                Franchise = "Predator",
                TrailerUrl = "https://www.youtube.com/watch?v=9h5fZsh3xpM"
            },
            new(){
                Id=57,
                Title = "Predator (1987)",
                ReleaseDate = new DateTime(1987, 6, 12),
                Description = "A team of elite soldiers on a mission in a Central American jungle find themselves hunted by an extraterrestrial warrior. The Predator, equipped with advanced technology and weaponry, stalks the team one by one. As the soldiers fight for survival, they must use their skills and ingenuity to outsmart the deadly alien hunter. The film combines action, suspense, and science fiction elements, while exploring themes of survival, courage, and the primal instincts of both humans and predators.",
                ImageUrl = "/images/movies/Predator.png",
                Review = "This was a great movie!",
                Genre = "Sci-Fi",
                Franchise = "Predator",
                TrailerUrl = "https://www.youtube.com/watch?v=E1Yp3n0kXh8"
            },
            new(){
                Id=58,
                Title = "Predator 2 (1990)",
                ReleaseDate = new DateTime(1990, 11, 21),
                Description = "In the midst of a violent gang war in Los Angeles, a new Predator arrives in the city to hunt. Lieutenant Mike Harrigan, a tough and determined cop, becomes entangled in the deadly game of cat and mouse with the alien hunter. As the body count rises, Harrigan must find a way to stop the Predator while dealing with corrupt officials and his own personal demons. The film combines action, suspense, and science fiction elements, while exploring themes of survival, justice, and the clash between different worlds.",
                ImageUrl = "/images/movies/Predator2.png",
                Review = "This was a great movie!",
                Genre = "Sci-Fi",
                Franchise = "Predator",
                TrailerUrl = "https://www.youtube.com/watch?v=6kYh9bn9kX8"
            },
            new(){
                Id=59,
                Title = "Prey (2022)",
                ReleaseDate = new DateTime(2022, 8, 5),
                Description = "Set in the early 18th century, a skilled Comanche warrior named Naru encounters a highly advanced alien Predator that has come to Earth to hunt. As Naru tracks the Predator through the wilderness, she must use her knowledge of the land and her hunting skills to outsmart the deadly alien. The film explores themes of survival, courage, and the clash between different cultures and technologies.",
                ImageUrl = "/images/movies/Prey.png",
                Review = "This was a great movie!",
                Genre = "Sci-Fi",
                Franchise = "Predator",
                TrailerUrl = "https://www.youtube.com/watch?v=HkMNOlYp6rY"
            }
        };

        public MovieModel? GetMovieById(int id)
        {
            return Movies.SingleOrDefault(m => m.Id == id);
        }

        public List<MovieModel>? GetMovies()
        {
            return Movies;
        }
        public List<MovieModel> GetMovies(int pageNumber, int pageSize)
        {
        return Movies
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToList();
        }

    }
}
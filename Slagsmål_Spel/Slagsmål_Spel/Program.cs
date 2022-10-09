using System;
int aiHp = 100;
int playerHp = 100;
//intro
Console.WriteLine("Hej och välkommen till The Ultimate Muay Thai experience.");
Console.WriteLine("Det du är intagen till den hemliga turneringen.");
Console.ReadLine();

//regler

string a = ReglerYesNo("Behöver du läsa reglerna/instruktionerna?");

if (a == "j")
{
Console.WriteLine("Under spelets gång kommer du möta ett flertal motståndare");
Console.WriteLine("När innan ni slåss kommer du bli presenterad med ett flertal attacker, attackerna gör olika mängder skada och har en minumum och maximum skada. Efter din attack kommer AI'n göra sina egna attacker.");
}
if (a == "n")
{
Console.WriteLine("Okej då kör vi");
}


Console.ReadLine();

static string ReglerYesNo(string QuestionText)
{
Console.WriteLine(QuestionText);
Console.WriteLine("[j/n]");

string anwser = Console.ReadLine().ToLower();


return anwser;
}

//namn

Console.WriteLine("Juste.. Vad heter du?");
string name = Console.ReadLine();
Console.WriteLine($"Okej {name}, hoppas du har vad som krävs..");
Console.ReadLine();

//boss selection

Random generator = new Random();
int chance = generator.Next(0, 5);
if (chance == 1)
{
string boss = "Jesper";
Console.WriteLine("Du kommer Slåss mot Jesper");
//boss selection done

}
if (chance == 2)
{
string boss = "Felix";
Console.WriteLine("Du kommer slåss mot Felix");
//boss selection done

}
if (chance == 3)
{
string boss = "Henry";
Console.WriteLine("Du kommer slåss mot Henry");
//boss selection done

}
if (chance == 4)
{
string boss = "tommi";
Console.WriteLine("Du kommer slåss mot Tommi");
//boss selection done
}

while (playerHp > 0 && aiHp > 0)
{
DefaultStance();
Console.ReadLine();
Console.WriteLine("Vad ska du göra?");
Console.ReadLine();
Console.WriteLine("a = Jab (15-20dmg)");
Console.WriteLine("b = Cross (12-30dmg)");
Console.WriteLine("c = Knä (5-45dmg)");
Console.WriteLine("d = Spark (10-40dmg)");
String move = Console.ReadLine();

if (move == "a")
{
jabStance();
int playerDmg = generator.Next(14,21);
aiHp -= playerDmg;
Console.WriteLine($"Du gör {playerDmg} skada på din motståndare.");
Console.WriteLine($"Din motståndare har nu {aiHp} hp kvar.");
}
if (move == "b")
{
crossStance();
int playerDmg = generator.Next(11,31);
aiHp -= playerDmg;
Console.WriteLine($"Du gör {playerDmg} skada på din motståndare.");
Console.WriteLine($"Din motståndare har nu {aiHp} hp kvar.");
}
if (move == "c")
{
kneeStance();
int playerDmg = generator.Next(4,46);
aiHp -= playerDmg;
Console.WriteLine($"Du gör {playerDmg} skada på din motståndare.");
Console.WriteLine($"Din motståndare har nu {aiHp} hp kvar.");
}
if (move == "d")
{
kickStance();
int playerDmg = generator.Next(9,41);
aiHp -= playerDmg;
Console.WriteLine($"Du gör {playerDmg} skada på din motståndare.");
Console.WriteLine($"Din motståndare har nu {aiHp} hp kvar.");
}

Console.ReadLine();
Console.WriteLine("Motståndarens tur!");

int aiDmg = generator.Next(0,7);
if (aiDmg == 1)
{
int aiDmgReal = 10;
playerHp -= aiDmgReal;
Console.WriteLine($"Din motståndare gör {aiDmgReal} skada på dig.");
Console.WriteLine($"Du har nu {playerHp} hp kvar.");
}

if (aiDmg == 2)
{
int aiDmgReal = 20;
playerHp -= aiDmgReal;
Console.WriteLine($"Din motståndare gör {aiDmgReal} skada på dig.");
Console.WriteLine($"Du har nu {playerHp} hp kvar.");
}

if (aiDmg == 3)
{
int aiDmgReal = 30;
playerHp -= aiDmgReal;
Console.WriteLine($"Din motståndare gör {aiDmgReal} skada på dig.");
Console.WriteLine($"Du har nu {playerHp} hp kvar.");
}

if (aiDmg == 4)
{
int aiDmgReal = 15;
playerHp -= aiDmgReal;
Console.WriteLine($"Din motståndare gör {aiDmgReal} skada på dig.");
Console.WriteLine($"Du har nu {playerHp} hp kvar.");
}

if (aiDmg == 5)
{
int aiDmgReal = 25;
playerHp -= aiDmgReal;
Console.WriteLine($"Din motståndare gör {aiDmgReal} skada på dig.");
Console.WriteLine($"Du har nu {playerHp} hp kvar.");
}

if (aiDmg == 6)
{
int aiDmgReal = 35;
playerHp -= aiDmgReal;
Console.WriteLine($"Din motståndare gör {aiDmgReal} skada på dig.");
Console.WriteLine($"Du har nu {playerHp} hp kvar.");
}
}
Console.WriteLine("En av er har vunnit..");
Console.ReadLine();

if (playerHp < 0 && aiHp < 0)
{
Console.WriteLine("Ni slog ner varandra... ingen vann egentligen.");
}
if (playerHp < 0)
{
Console.WriteLine("Tyvär du förloade...");
}
if (aiHp < 0);
{
Console.WriteLine("Grattis du vann!");
}
Console.ReadLine();

//boss är vald

//default stance
static void DefaultStance()
{
Console.WriteLine(@$"

               (Spelare)                              (AI)
              
                 @#                                    @@@                      
               @@@@@                                  @@@@@                     
              @@@@  @@@  @@                    @@. @@@  @@@@@                   
           @@@@@@@@@@@   @                      @.  @@@@@@@@@@@                 
            @@@@@@@ &@@@@@                      @@@@@  @@@@@@@                  
            @@@@@@      @@@@                  @@@@@     @@@@@@                  
             @@@@@@@@@@@@@@@                  ,@@@@@@@@@@@@@@                   
              @@@@@@@@@@@@@                    @@@ @@@@@@@@@                    
              @@&@@@    &@                      @@    @@@@@&                    
               @@@@@   @@                        @@   @@@@@                     
                @@@@    @@                      ,@    .@@@                      
                @@@                                    @@@                      
                @@@                                    @@@                      
                @@@                                    %@@                      
                (@#                                     @&                      
                 @@                                     @@  ");
                 
}
static void jabStance()
{
Console.WriteLine(@"                                                                                
                          &&&&&&&&                           ,@@@@@             
                        &&&&&&&&&&&&&,&&@              @      ,@@@@             
                      &&&&&&&*                        @@   @@  .@@@@@@@         
                   #&&&&&&&,&&*                       %@@ .@@@@@@@@@@@@@        
                   &&&&&&&.&&                          @@@@@%  @@@@@@@@         
                   &&&&&&&&&                         @@@@.     (@@@@@@@         
                    &&&&&%#                          @@@@@@@@@@@@@@@@@          
                  &&&&&&&&                           @@@@@@@@@@@@@@@@           
                  &&&&&&&&                            @@@  @@@@@@@@@@           
                  &&&&&&&&                             @@(    @@@@@@            
                  &&&&&&&&%                            @@     @@@@@             
                 /&&&&&&&&&                            @@     @@@@              
                 #&&&#  &&&                                   .@@@              
               &&&&&   (&&&                                    @@@              
             .&&&&      &&/                                    @@@              
            .&&&        &&,                                    @@@              
           &&&         ,&&&*                                   @@               
          ,&&&&                                               @@@    ");
}

static void crossStance()
{
Console.WriteLine(@"  
                       &&&&&&&&                           ,@@@@@             
                        &&&&&&&&&&&&&,&&@              @      ,@@@@             
                      &&&&&&&*                        @@   @@  .@@@@@@@         
                   #&&&&&&&,&&*                       %@@ .@@@@@@@@@@@@@        
                   &&&&&&&.&&                          @@@@@%  @@@@@@@@         
                   &&&&&&&&&                         @@@@.     (@@@@@@@         
                    &&&&&%#                          @@@@@@@@@@@@@@@@@          
                  &&&&&&&&                           @@@@@@@@@@@@@@@@           
                  &&&&&&&&                            @@@  @@@@@@@@@@           
                  &&&&&&&&                             @@(    @@@@@@            
                  &&&&&&&&%                            @@     @@@@@             
                 /&&&&&&&&&                            @@     @@@@              
                 #&&&#  &&&                                   .@@@              
               &&&&&   (&&&                                    @@@              
             .&&&&      &&/                                    @@@              
            .&&&        &&,                                    @@@              
           &&&         ,&&&*                                   @@               
          ,&&&&                                               @@@   ");
}

static void kneeStance()
{
Console.WriteLine(@" 
           (@@#                                             @@@@@              
      ,/   @@@@@/@ /                                         @@@@@@             
      (@  %@@@@@@@@@@@@@@&                          @@@  @@@   @@@@@@           
          @@@@@@@@#%#  @&                           @@.    @@@@@@@@@@@@@        
          &@@@@@@@@@ .@@        *@@@@*               @@@@@@@@@@@@@@@@@@*        
           @@@@@@@@@@@(     .@@@@@@@@.                @@*     @@@@@@@@@         
               @@@@@@@@@@@@@@@@@@@@@&             /@@@@@@      @@@@@@@          
                  @@@@@@@@@@@@@*@@@&               @@@@@@@@@@@@@@@@@@           
                   @@@@@@@@@@@, @@@                @@@@*@@@@@@@@@@@@@           
                   @@@@@@@@@( *@@@                  @@@*  @@@@@@@@@@            
                   *@@@@@@@@%  @@                    @&@     &@@@@@@            
                    @@@@@@*    &                      @@/   @@@@@@@             
                     @@@@                             @      @@@@@              
                   ,@@@@.                                    @@@@               
                  @@@@,                                       @@@               
                  @@@                                         @@@@              
                 &@%                                          &@@@              
                @@@                                           *@@               
                /@@                                           @@@               
                                                            @@@@*  ");
}

static void kickStance()
{
Console.WriteLine(@" 
                                                                                  @@@@             
                                                                                 &@@@@@@&           
               #&&&&*                                                             @@@@@@@           
       &&*    &&&&&&&&                                                 @@@,  @@@@   @@@@@@@         
              &&&&&&&* %&&&&                                           &@@     @@@@@@@@@@@@@@@@     
              &&&&&&&&&&(                                               @@@  @@@@@@@@@@@@@@@@@@     
          &&&&&&&&&&&&&&                                                *@@@@@@@@ @@@@@@@@@@@@*     
          %&&&&&&&&&&&&&%                                              @%           @@@@@@@@@@      
            &&&&&&&&&&&&&&&#                           &&            @@@@@@@@*      @@@@@@@@@       
               %&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%              @@@@@@@@@@@@@@@@@@@@@@        
                  &&&&&&&&&&&&&&&&&&&&&&&#                            @@@@@@@@@@@@@@@@@@@@@%        
                    &&&&&&&&&&&&&&&                                    @@@@ @@@@@@@@@@@@@@@         
                    &&&&&&&&&.                                          @@@     @@@@@@@@@@@         
                     &&&&&&&,                                            @@@     #@@@@@@@@          
                     &&&&&&.                                             @@@@    @@@@@@@@           
                     #&&&&.                                              @@       @@@@@@            
                     &&&&,                                               @        @@@@@@            
                    &&&&/                                                          @@@@             
                    &&&&                                                           @@@@             
                    &&&.                                                           *@@@@            
                    &&/                                                             @@@@            
                    &&                                                              @@@             
                   &&&                                                              @@@             
                 &&&&                                                              &@@              
                                                                                 @@@@@   ");
}

/*
//fighting moves
static void FightMove()
{
Console.WriteLine("Vad ska du göra?");
Console.ReadLine();
Console.WriteLine("a = Jab (15-20dmg)");
Console.WriteLine("b = Cross (12-30dmg)");
Console.WriteLine("c = Knä (5-45dmg)");
Console.WriteLine("d = Spark (10-40dmg)");
String move = Console.ReadLine();

if (move == "a")
{
Random generator = new Random();
int playerDmg = generator.Next(14,21);
aiHp -= playerDmg;
Console.WriteLine($"Du gör {playerDmg} skada på din motståndare.");
Console.WriteLine($"Din motståndare har nu {aiHp} hp kvar.");
}
if (move == "b")
{
Random generator = new Random();
int playerDmg = generator.Next(11,31);
aiHp -= playerDmg;
Console.WriteLine($"Du gör {playerDmg} skada på din motståndare.");
Console.WriteLine($"Din motståndare har nu {aiHp} hp kvar.");
}
if (move == "c")
{
Random generator = new Random();
int playerDmg = generator.Next(4,46);
aiHp -= playerDmg;
Console.WriteLine($"Du gör {playerDmg} skada på din motståndare.");
Console.WriteLine($"Din motståndare har nu {aiHp} hp kvar.");
}
if (move == "d")
{
Random generator = new Random();
int playerDmg = generator.Next(9,41);
aiHp -= playerDmg;
Console.WriteLine($"Du gör {playerDmg} skada på din motståndare.");
Console.WriteLine($"Din motståndare har nu {aiHp} hp kvar.");
}
}

//Ai attack turn
/*
static void AiMove()
{
Random generator = new Random ();
int aiDmg = generator.Next(0,7);
if (aiDmg == 1)
{
int aiDmgReal = 10;
playerHp -= aiDmgReal;
Console.WriteLine($"Din motståndare gör {aiDmgReal} skada på dig.");
Console.WriteLine($"Du har nu {playerHp} hp kvar.");
}

if (aiDmg == 2)
{
int aiDmgReal = 20;
playerHp -= aiDmgReal;
Console.WriteLine($"Din motståndare gör {aiDmgReal} skada på dig.");
Console.WriteLine($"Du har nu {playerHp} hp kvar.");
}

if (aiDmg == 3)
{
int aiDmgReal = 30;
playerHp -= aiDmgReal;
Console.WriteLine($"Din motståndare gör {aiDmgReal} skada på dig.");
Console.WriteLine($"Du har nu {playerHp} hp kvar.");
}

if (aiDmg == 4)
{
int aiDmgReal = 15;
playerHp -= aiDmgReal;
Console.WriteLine($"Din motståndare gör {aiDmgReal} skada på dig.");
Console.WriteLine($"Du har nu {playerHp} hp kvar.");
}

if (aiDmg == 5)
{
int aiDmgReal = 25;
playerHp -= aiDmgReal;
Console.WriteLine($"Din motståndare gör {aiDmgReal} skada på dig.");
Console.WriteLine($"Du har nu {playerHp} hp kvar.");
}

if (aiDmg == 6)
{
int aiDmgReal = 35;
playerHp -= aiDmgReal;
Console.WriteLine($"Din motståndare gör {aiDmgReal} skada på dig.");
Console.WriteLine($"Du har nu {playerHp} hp kvar.");
}
}










//random gen
/*
string move1 = Console.ReadLine();

Random generator = new Random();
while (true)
{
if (move1 == a)
{
int result = generator.Next(5, 15);
Console.WriteLine(result);
}
}
Console.ReadLine();




























/*
Random generator = new Random();

while (true)
{
int result = generator.Next(5, 15);
Console.WriteLine(result);



if (result == 0);
{
Console.WriteLine("Du får en banan");
}

if (result == 1)
{
Console.WriteLine("Du får en annan banan");

}


Console.ReadLine();
}





int hp = 5;

while (hp > 0)
{
Console.WriteLine("Still alive!");
Console.WriteLine(hp);
hp--;
}

Console.ReadLine();
*/
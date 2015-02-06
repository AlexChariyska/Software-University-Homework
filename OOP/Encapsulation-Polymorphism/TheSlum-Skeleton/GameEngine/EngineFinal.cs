namespace TheSlum.GameEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    class EngineFinal : Engine
    {
        protected override void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "create":
                    this.CreateCharacter(inputParams);
                    break;
                case "add":
                    this.AddItem(inputParams);
                    break;
                default:
                    break;
            }
        }

        protected override void CreateCharacter(string[] inputParams)
        {
            Character character;
            Team team;
            switch (inputParams[5].ToLower())
            {
                case "red":
                    team = Team.Red;
                    break;
                case "blue":
                    team = Team.Blue;
                    break;
                default:
                    throw new ApplicationException("Wrong color team.");
            }

            switch (inputParams[1].ToLower())
            {
                case "warrior":
                    character = new Warrior(
                        id: inputParams[2],
                        x: int.Parse(inputParams[3]),
                        y: int.Parse(inputParams[4]),
                        healthPoints: 200,
                        defensePoints: 100,
                        team: team,
                        range: 2,
                        attackPoints: 150);
                    break;

                case "healer":
                    character = new Healer(
                        id: inputParams[2],
                        x: int.Parse(inputParams[3]),
                        y: int.Parse(inputParams[4]),
                        healthPoints: 75,
                        defensePoints: 50,
                        team: team,
                        range: 6,
                        healingPoints: 60);
                    break;

                case "mage":
                    character = new Mage(
                        id: inputParams[2],
                        x: int.Parse(inputParams[3]),
                        y: int.Parse(inputParams[4]),
                        healthPoints: 150,
                        defensePoints: 50,
                        team: team,
                        range: 5,
                        attackPoints: 300);
                    break;

                default:
                    throw new ApplicationException("Your character is invalid.");
            }

            this.characterList.Add(character);
        }

        private new void AddItem(string[] inputParams)
        {
            Item item;
            switch (inputParams[2].ToLower())
            {
                case "axe":
                    item = new Axe(inputParams[3]);
                    break;
                case "shield":
                    item = new Shield(inputParams[3]);
                    break;
                case "injection":
                    item = new Injection(inputParams[3]);
                    break;
                case "pill":
                    item = new Pill(inputParams[3]);
                    break;
                default:
                    throw new ApplicationException("No such kind of item in the game.");
            }

            var character = this.characterList.First(c => c.Id == inputParams[1]);
            character.AddToInventory(item);

        }
    }
}

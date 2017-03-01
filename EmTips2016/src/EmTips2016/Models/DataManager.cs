using EmTips2016.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace EmTips2016.Models
{
    public class DataManager
    {

        EmDbContext context;

        public DataManager(EmDbContext context)
        {
            this.context = context;
        }

        public string PlaceSomeBets(BetViewModel[] model)
        {

            var person = context.User
                .Where(o => o.Username.ToLower() == model[0].name.ToLower())
                .FirstOrDefault();

            


            if (person != null && person.Match1 == null)
            {
                person.Match1 = model[1].name;
                person.Match2 = model[2].name;
                person.Match3 = model[3].name;
                person.Match4 = model[4].name;
                person.Match5 = model[5].name;
                person.Match6 = model[6].name;
                person.Match7 = model[7].name;
                person.Match8 = model[8].name;
                person.Match9 = model[9].name;
                person.Match10 = model[10].name;
                person.Match11 = model[11].name;
                person.Match12 = model[12].name;
                person.Match13 = model[13].name;
                person.Match14 = model[14].name;
                person.Match15 = model[15].name;
                person.Match16 = model[16].name;
                person.Match17 = model[17].name;
                person.Match18 = model[18].name;
                person.Match19 = model[19].name;
                person.Match20 = model[20].name;
                person.Match21 = model[21].name;
                person.Match22 = model[22].name;
                person.Match23 = model[23].name;
                person.Match24 = model[24].name;
                person.Match25 = model[25].name;
                person.Match26 = model[26].name;
                person.Match27 = model[27].name;
                person.Match28 = model[28].name;
                person.Match29 = model[29].name;
                person.Match30 = model[30].name;
                person.Match31 = model[31].name;
                person.Match32 = model[32].name;
                person.Match33 = model[33].name;
                person.Match34 = model[34].name;
                person.Match35 = model[35].name;
                person.Match36 = model[36].name;

                context.User.Update(person);
                context.SaveChanges();

                return "success";
            }
            else
                return "User not found";


        }

        internal void CreateUser(UserVM model)
        {
            context.User.Add(new User { Username = model.UserName });
            context.SaveChanges();
        }

        public LeaderboardVM[] GetLeaderBoard()
        {
            return context.User
                .Where(o => o.Match1 != null)
                .OrderByDescending(o => o.Points)
                .Select(o => new LeaderboardVM { Points = o.Points, Username = o.Username, Id = o.Id })
                .ToArray();
        }

        public List<string> GetStatsForSpecificUser(int id)
        {
            var list = new List<string>();

            var person = context.User
                 .Where(o => o.Id == id)
                 .FirstOrDefault();

            list.Add(person.Username.ToString());
            list.Add(person.Match1.ToString());
            list.Add(person.Match2.ToString());
            list.Add(person.Match3.ToString());
            list.Add(person.Match4.ToString());
            list.Add(person.Match5.ToString());
            list.Add(person.Match6.ToString());
            list.Add(person.Match7.ToString());
            list.Add(person.Match8.ToString());
            list.Add(person.Match9.ToString());
            list.Add(person.Match10.ToString());
            list.Add(person.Match11.ToString());
            list.Add(person.Match12.ToString());
            list.Add(person.Match13.ToString());
            list.Add(person.Match14.ToString());
            list.Add(person.Match15.ToString());
            list.Add(person.Match16.ToString());
            list.Add(person.Match17.ToString());
            list.Add(person.Match18.ToString());
            list.Add(person.Match19.ToString());
            list.Add(person.Match20.ToString());
            list.Add(person.Match21.ToString());
            list.Add(person.Match22.ToString());
            list.Add(person.Match23.ToString());
            list.Add(person.Match24.ToString());
            list.Add(person.Match25.ToString());
            list.Add(person.Match26.ToString());
            list.Add(person.Match27.ToString());
            list.Add(person.Match28.ToString());
            list.Add(person.Match29.ToString());
            list.Add(person.Match30.ToString());
            list.Add(person.Match31.ToString());
            list.Add(person.Match32.ToString());
            list.Add(person.Match33.ToString());
            list.Add(person.Match34.ToString());
            list.Add(person.Match35.ToString());
            list.Add(person.Match36.ToString());

            var trimmedList = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                if (i != 0)
                {
                    string item2;
                    item2 = list[i].Substring(0, list[i].Length - 1);
                    if (item2.Length == 3)
                        trimmedList.Add(item2);
                    else
                        trimmedList.Add(list[i]);
                }
                else
                    trimmedList.Add(list[i]);

            }


            return trimmedList;

        }

        public List<string> GetStatsForSpecificUserAdv(string username)
        {
            var list = new List<string>();
            var person = context.AdvanceBet
                .Where(o => o.Username == username)
                .FirstOrDefault();
            if (person != null)
            {

                list.Add(person.Frankrike.ToString());
                list.Add(person.Rumänien.ToString());
                list.Add(person.Albanien.ToString());
                list.Add(person.Schweiz.ToString());
                list.Add(person.England.ToString());
                list.Add(person.Ryssland.ToString());
                list.Add(person.Wales.ToString());
                list.Add(person.Slovakien.ToString());
                list.Add(person.Tyskland.ToString());
                list.Add(person.Polen.ToString());
                list.Add(person.Ukraina.ToString());
                list.Add(person.Nordirland.ToString());
                list.Add(person.Spanien.ToString());
                list.Add(person.Tjeckien.ToString());
                list.Add(person.Turkiet.ToString());
                list.Add(person.Kroatien.ToString());
                list.Add(person.Belgien.ToString());
                list.Add(person.Italien.ToString());
                list.Add(person.Irland.ToString());
                list.Add(person.Sverige.ToString());
                list.Add(person.Portugal.ToString());
                list.Add(person.Island.ToString());
                list.Add(person.Österrike.ToString());
                list.Add(person.Ungern.ToString());

                var trimmedList = new List<string>();
                for (int i = 0; i < list.Count; i++)
                {
                    string item2;
                    var x = list[i].Substring(list[i].Length - 1);
                    item2 = list[i].Substring(0, list[i].Length - 1);
                    if (x == "X")
                        trimmedList.Add(item2);
                    else
                        trimmedList.Add(list[i]);
                }
                return trimmedList;
            }
            else
            {
                return list;
            }

        }

        internal void CalcAdvStats(CalcAdvVM[] items)
        {
            var ListofAdvBets = context.AdvanceBet
                .ToList();

            for (int i = 0; i < items.Length; i++)
            {
                foreach (var bet in ListofAdvBets)
                {
                    int points = 0;
                    if (items[i].name == "Albanien" && items[i].adv.Length > 2)
                    {
                        points += CalcMethodOnAdv(bet.Albanien, items[i].adv);
                        //points += checkHowManyPoints(items[i].adv);
                        if (points > 0)
                            bet.Albanien = bet.Albanien += "X";
                    }

                    if (items[i].name == "Frankrike" && items[i].adv.Length > 2)
                    {
                        points += CalcMethodOnAdv(bet.Frankrike, items[i].adv);
                        //points += checkHowManyPoints(items[i].adv);
                        if (points > 0)
                            bet.Frankrike = bet.Frankrike += "X";
                    }

                    if (items[i].name == "Schweiz" && items[i].adv.Length > 2)
                    {
                        points += CalcMethodOnAdv(bet.Frankrike, items[i].adv);
                        //points += checkHowManyPoints(items[i].adv);
                        if (points > 0)
                            bet.Schweiz = bet.Schweiz += "X";
                    }

                    if (items[i].name == "Rumänien" && items[i].adv.Length > 2)
                    {
                        points += CalcMethodOnAdv(bet.Rumänien, items[i].adv);
                        //points += checkHowManyPoints(items[i].adv);
                        if (points > 0)
                            bet.Rumänien = bet.Rumänien += "X";
                    }

                    if (items[i].name == "England" && items[i].adv.Length > 2)
                    {
                        points += CalcMethodOnAdv(bet.England, items[i].adv);
                        if (points > 0)
                            bet.England = bet.England += "X";
                    }

                    if (items[i].name == "Ryssland" && items[i].adv.Length > 2)
                    {
                        points += CalcMethodOnAdv(bet.Ryssland, items[i].adv);
                        //points += checkHowManyPoints(items[i].adv);
                        if (points > 0)
                            bet.Ryssland = bet.Ryssland += "X";
                    }

                    if (items[i].name == "Wales" && items[i].adv.Length > 2)
                    {
                        points += CalcMethodOnAdv(bet.Wales, items[i].adv);
                        //points += checkHowManyPoints(items[i].adv);
                        if (points > 0)
                            bet.Wales = bet.Wales += "X";
                    }

                    if (items[i].name == "Slovakien" && items[i].adv.Length > 2)
                    {
                        points += CalcMethodOnAdv(bet.Slovakien, items[i].adv);
                        //points += checkHowManyPoints(items[i].adv);
                        if (points > 0)
                            bet.Slovakien = bet.Slovakien += "X";
                    }

                    if (items[i].name == "Tyskland" && items[i].adv.Length > 2)
                    {
                        points += CalcMethodOnAdv(bet.Tyskland, items[i].adv);
                        //points += checkHowManyPoints(items[i].adv);
                        if (points > 0)
                            bet.Tyskland = bet.Tyskland += "X";
                    }

                    if (items[i].name == "Polen" && items[i].adv.Length > 2)
                    {
                        points += CalcMethodOnAdv(bet.Polen, items[i].adv);
                        //points += checkHowManyPoints(items[i].adv);
                        if (points > 0)
                            bet.Polen = bet.Polen += "X";
                    }

                    if (items[i].name == "Ukraina" && items[i].adv.Length > 2)
                    {
                        points += CalcMethodOnAdv(bet.Ukraina, items[i].adv);
                        //points += checkHowManyPoints(items[i].adv);
                        if (points > 0)
                            bet.Ukraina = bet.Ukraina += "X";
                    }

                    if (items[i].name == "Nordirland" && items[i].adv.Length > 2)
                    {
                        points += CalcMethodOnAdv(bet.Nordirland, items[i].adv);
                        //points += checkHowManyPoints(items[i].adv);
                        if (points > 0)
                            bet.Nordirland = bet.Nordirland += "X";
                    }

                    if (items[i].name == "Spanien" && items[i].adv.Length > 2)
                    {
                        points += CalcMethodOnAdv(bet.Spanien, items[i].adv);
                        //points += checkHowManyPoints(items[i].adv);
                        if (points > 0)
                            bet.Spanien = bet.Spanien += "X";
                    }

                    if (items[i].name == "Tjeckien" && items[i].adv.Length > 2)
                    {
                        points += CalcMethodOnAdv(bet.Tjeckien, items[i].adv);
                        //points += checkHowManyPoints(items[i].adv);
                        if (points > 0)
                            bet.Tjeckien = bet.Tjeckien += "X";
                    }

                    if (items[i].name == "Turkiet" && items[i].adv.Length > 2)
                    {
                        points += CalcMethodOnAdv(bet.Turkiet, items[i].adv);
                        //points += checkHowManyPoints(items[i].adv);
                        if (points > 0)
                            bet.Turkiet = bet.Turkiet += "X";
                    }

                    if (items[i].name == "Kroatien" && items[i].adv.Length > 2)
                    {
                        points += CalcMethodOnAdv(bet.Kroatien, items[i].adv);
                        //points += checkHowManyPoints(items[i].adv);
                        if (points > 0)
                            bet.Kroatien = bet.Kroatien += "X";
                    }

                    if (items[i].name == "Belgien" && items[i].adv.Length > 2)
                    {
                        points += CalcMethodOnAdv(bet.Belgien, items[i].adv);
                        //points += checkHowManyPoints(items[i].adv);
                        if (points > 0)
                            bet.Belgien = bet.Belgien += "X";
                    }

                    if (items[i].name == "Italien" && items[i].adv.Length > 2)
                    {
                        points += CalcMethodOnAdv(bet.Italien, items[i].adv);
                        //points += checkHowManyPoints(items[i].adv);
                        if (points > 0)
                            bet.Italien = bet.Italien += "X";
                    }

                    if (items[i].name == "Irland" && items[i].adv.Length > 2)
                    {
                        points += CalcMethodOnAdv(bet.Irland, items[i].adv);
                        //points += checkHowManyPoints(items[i].adv);
                        if (points > 0)
                            bet.Irland = bet.Irland += "X";
                    }

                    if (items[i].name == "Sverige" && items[i].adv.Length > 2)
                    {
                        points += CalcMethodOnAdv(bet.Sverige, items[i].adv);
                        //points += checkHowManyPoints(items[i].adv);
                        if (points > 0)
                            bet.Sverige = bet.Sverige += "X";
                    }

                    if (items[i].name == "Portugal" && items[i].adv.Length > 2)
                    {
                        points += CalcMethodOnAdv(bet.Albanien, items[i].adv);
                        //points += checkHowManyPoints(items[i].adv);
                        if (points > 0)
                            bet.Portugal = bet.Portugal += "X";
                    }
                    if (items[i].name == "Island" && items[i].adv.Length > 2)
                    {
                        points += CalcMethodOnAdv(bet.Island, items[i].adv);
                        //points += checkHowManyPoints(items[i].adv);
                        if (points > 0)
                            bet.Island = bet.Island += "X";
                    }
                    if (items[i].name == "Österrike" && items[i].adv.Length > 2)
                    {
                        points += CalcMethodOnAdv(bet.Österrike, items[i].adv);
                        //points += checkHowManyPoints(items[i].adv);
                        if (points > 0)
                            bet.Österrike = bet.Österrike += "X";
                    }
                    if (items[i].name == "Ungern" && items[i].adv.Length > 2)
                    {
                        points += CalcMethodOnAdv(bet.Ungern, items[i].adv);
                        //points += checkHowManyPoints(items[i].adv);
                        if (points > 0)
                            bet.Ungern = bet.Ungern += "X";
                    }
                    context.AdvanceBet.Update(bet);
                    context.SaveChanges();

                    var userToGivePoints = context.User
                        .Where(o => o.Username == bet.Username)
                        .SingleOrDefault();
                    userToGivePoints.Points += points;
                    context.User.Update(userToGivePoints);
                    context.SaveChanges();
                }

            }

        }

        //private int checkHowManyPoints(string result)
        //{
        //    int points = 0;

        //    if (result == "Gruppspel")
        //        points = 2;
        //    if (result == "Åttondelsfinal")
        //        points = 4;
        //    if (result == "Kvartsfinal")
        //        points = 6;
        //    if (result == "Semifinal")
        //        points = 8;
        //    if (result == "Final")
        //        points = 10;
        //    if (result == "Mästare")
        //        points = 15;

        //    return points;
        //}

        internal string placeSomeAdvBets(AdvanceTeamVM viewModel)
        {
            var bet = context.AdvanceBet
                .Where(o => o.Username.ToLower() == viewModel.Username.ToLower())
                .SingleOrDefault();

            var person = context.User
                .Where(o => o.Username.ToLower() == viewModel.Username.ToLower())
                .SingleOrDefault();

            if (bet == null && person != null)
            {

                context.AdvanceBet.Add(new AdvanceBet
                {
                    Username = viewModel.Username,
                    Schweiz = viewModel.Schweiz,
                    Albanien = viewModel.Albanien,
                    Belgien = viewModel.Belgien,
                    England = viewModel.England,
                    Frankrike = viewModel.Frankrike,
                    Irland = viewModel.Irland,
                    Island = viewModel.Island,
                    Italien = viewModel.Italien,
                    Kroatien = viewModel.Kroatien,
                    Nordirland = viewModel.Nordirland,
                    Polen = viewModel.Polen,
                    Portugal = viewModel.Portugal,
                    Rumänien = viewModel.Rumänien,
                    Ryssland = viewModel.Ryssland,
                    Slovakien = viewModel.Slovakien,
                    Spanien = viewModel.Spanien,
                    Sverige = viewModel.Sverige,
                    Tjeckien = viewModel.Tjeckien,
                    Turkiet = viewModel.Turkiet,
                    Tyskland = viewModel.Tyskland,
                    Ukraina = viewModel.Ukraina,
                    Ungern = viewModel.Ungern,
                    Wales = viewModel.Wales,
                    Österrike = viewModel.Österrike
                });
                context.SaveChanges();
                return "success";
            }
            else
                return "failed";
        }

        public void CalcStats(CalcResVM[] results)
        {
            var users = context.User
                .ToList();

            for (int i = 0; i < users.Count; i++)
            {
                int x = results.Length; //checks how many results we should calculate
                if (x > 0)
                {
                    //sends bet and result to method. Then adds a "c" marking that bet has been calculated and should not be again
                    var pointsToAdd = CalcMethod(users[i].Match1, results[0].name);
                    if (pointsToAdd > 0)
                    {
                        users[i].Points += pointsToAdd;
                        users[i].Match1 = users[i].Match1 += "c";
                    }
                }
                #region Does this for 36 times. Cannot loop because of propertys.
                if (x > 1)
                {
                    var pointsToAdd = CalcMethod(users[i].Match2, results[1].name);
                    if (pointsToAdd > 0)
                    {
                        users[i].Points += pointsToAdd;
                        users[i].Match2 = users[i].Match2 += "c";
                    }
                }
                if (x > 2)
                {
                    var pointsToAdd = CalcMethod(users[i].Match3, results[2].name);
                    if (pointsToAdd > 0)
                    {
                        users[i].Points += pointsToAdd;
                        users[i].Match3 = users[i].Match3 += "c";
                    }
                }
                if (x > 3)
                {
                    var pointsToAdd = CalcMethod(users[i].Match4, results[3].name);
                    if (pointsToAdd > 0)
                    {
                        users[i].Points += pointsToAdd;
                        users[i].Match4 = users[i].Match4 += "c";
                    }
                }
                if (x > 4)
                {
                    var pointsToAdd = CalcMethod(users[i].Match5, results[4].name);
                    if (pointsToAdd > 0)
                    {
                        users[i].Points += pointsToAdd;
                        users[i].Match5 = users[i].Match5 += "c";
                    }
                }
                if (x > 5)
                {
                    var pointsToAdd = CalcMethod(users[i].Match6, results[5].name);
                    if (pointsToAdd > 0)
                    {
                        users[i].Points += pointsToAdd;
                        users[i].Match6 = users[i].Match6 += "c";
                    }
                }
                if (x > 6)
                {
                    var pointsToAdd = CalcMethod(users[i].Match7, results[6].name);
                    if (pointsToAdd > 0)
                    {
                        users[i].Points += pointsToAdd;
                        users[i].Match7 = users[i].Match7 += "c";
                    }
                }
                if (x > 7)
                {
                    var pointsToAdd = CalcMethod(users[i].Match8, results[7].name);
                    if (pointsToAdd > 0)
                    {
                        users[i].Points += pointsToAdd;
                        users[i].Match8 = users[i].Match8 += "c";
                    }
                }
                if (x > 8)
                {
                    var pointsToAdd = CalcMethod(users[i].Match9, results[8].name);
                    if (pointsToAdd > 0)
                    {
                        users[i].Points += pointsToAdd;
                        users[i].Match9 = users[i].Match9 += "c";
                    }
                }
                if (x > 9)
                {
                    var pointsToAdd = CalcMethod(users[i].Match10, results[9].name);
                    if (pointsToAdd > 0)
                    {
                        users[i].Points += pointsToAdd;
                        users[i].Match10 = users[i].Match10 += "c";
                    }
                }
                if (x > 10)
                {
                    var pointsToAdd = CalcMethod(users[i].Match11, results[10].name);
                    if (pointsToAdd > 0)
                    {
                        users[i].Points += pointsToAdd;
                        users[i].Match11 = users[i].Match11 += "c";
                    }
                }
                if (x > 11)
                {
                    var pointsToAdd = CalcMethod(users[i].Match12, results[11].name);
                    if (pointsToAdd > 0)
                    {
                        users[i].Points += pointsToAdd;
                        users[i].Match12 = users[i].Match12 += "c";
                    }
                }
                if (x > 12)
                {
                    var pointsToAdd = CalcMethod(users[i].Match13, results[12].name);
                    if (pointsToAdd > 0)
                    {
                        users[i].Points += pointsToAdd;
                        users[i].Match13 = users[i].Match13 += "c";
                    }
                }
                if (x > 13)
                {
                    var pointsToAdd = CalcMethod(users[i].Match14, results[13].name);
                    if (pointsToAdd > 0)
                    {
                        users[i].Points += pointsToAdd;
                        users[i].Match14 = users[i].Match14 += "c";
                    }
                }
                if (x > 14)
                {
                    var pointsToAdd = CalcMethod(users[i].Match15, results[14].name);
                    if (pointsToAdd > 0)
                    {
                        users[i].Points += pointsToAdd;
                        users[i].Match15 = users[i].Match15 += "c";
                    }
                }
                if (x > 15)
                {
                    var pointsToAdd = CalcMethod(users[i].Match16, results[15].name);
                    if (pointsToAdd > 0)
                    {
                        users[i].Points += pointsToAdd;
                        users[i].Match16 = users[i].Match16 += "c";
                    }
                }
                if (x > 16)
                {
                    var pointsToAdd = CalcMethod(users[i].Match17, results[16].name);
                    if (pointsToAdd > 0)
                    {
                        users[i].Points += pointsToAdd;
                        users[i].Match17 = users[i].Match17 += "c";
                    }
                }
                if (x > 17)
                {
                    var pointsToAdd = CalcMethod(users[i].Match18, results[17].name);
                    if (pointsToAdd > 0)
                    {
                        users[i].Points += pointsToAdd;
                        users[i].Match18 = users[i].Match18 += "c";
                    }
                }
                if (x > 18)
                {
                    var pointsToAdd = CalcMethod(users[i].Match19, results[18].name);
                    if (pointsToAdd > 0)
                    {
                        users[i].Points += pointsToAdd;
                        users[i].Match19 = users[i].Match19 += "c";
                    }
                }
                if (x > 19)
                {
                    var pointsToAdd = CalcMethod(users[i].Match20, results[19].name);
                    if (pointsToAdd > 0)
                    {
                        users[i].Points += pointsToAdd;
                        users[i].Match20 = users[i].Match20 += "c";
                    }
                }
                if (x > 20)
                {
                    var pointsToAdd = CalcMethod(users[i].Match21, results[20].name);
                    if (pointsToAdd > 0)
                    {
                        users[i].Points += pointsToAdd;
                        users[i].Match21 = users[i].Match21 += "c";
                    }
                }
                if (x > 21)
                {
                    var pointsToAdd = CalcMethod(users[i].Match22, results[21].name);
                    if (pointsToAdd > 0)
                    {
                        users[i].Points += pointsToAdd;
                        users[i].Match22 = users[i].Match22 += "c";
                    }
                }
                if (x > 22)
                {
                    var pointsToAdd = CalcMethod(users[i].Match23, results[22].name);
                    if (pointsToAdd > 0)
                    {
                        users[i].Points += pointsToAdd;
                        users[i].Match23 = users[i].Match23 += "c";
                    }
                }
                if (x > 23)
                {
                    var pointsToAdd = CalcMethod(users[i].Match24, results[23].name);
                    if (pointsToAdd > 0)
                    {
                        users[i].Points += pointsToAdd;
                        users[i].Match24 = users[i].Match24 += "c";
                    }
                }
                if (x > 24)
                {
                    var pointsToAdd = CalcMethod(users[i].Match25, results[24].name);
                    if (pointsToAdd > 0)
                    {
                        users[i].Points += pointsToAdd;
                        users[i].Match25 = users[i].Match24 += "c";
                    }
                }
                if (x > 25)
                {
                    var pointsToAdd = CalcMethod(users[i].Match26, results[25].name);
                    if (pointsToAdd > 0)
                    {
                        users[i].Points += pointsToAdd;
                        users[i].Match26 = users[i].Match26 += "c";
                    }
                }
                if (x > 26)
                {
                    var pointsToAdd = CalcMethod(users[i].Match27, results[26].name);
                    if (pointsToAdd > 0)
                    {
                        users[i].Points += pointsToAdd;
                        users[i].Match27 = users[i].Match27 += "c";
                    }
                }
                if (x > 27)
                {
                    var pointsToAdd = CalcMethod(users[i].Match28, results[27].name);
                    if (pointsToAdd > 0)
                    {
                        users[i].Points += pointsToAdd;
                        users[i].Match28 = users[i].Match28 += "c";
                    }
                }
                if (x > 28)
                {
                    var pointsToAdd = CalcMethod(users[i].Match29, results[28].name);
                    if (pointsToAdd > 0)
                    {
                        users[i].Points += pointsToAdd;
                        users[i].Match29 = users[i].Match29 += "c";
                    }
                }
                if (x > 29)
                {
                    var pointsToAdd = CalcMethod(users[i].Match30, results[29].name);
                    if (pointsToAdd > 0)
                    {
                        users[i].Points += pointsToAdd;
                        users[i].Match30 = users[i].Match30 += "c";
                    }
                }
                if (x > 30)
                {
                    var pointsToAdd = CalcMethod(users[i].Match31, results[30].name);
                    if (pointsToAdd > 0)
                    {
                        users[i].Points += pointsToAdd;
                        users[i].Match31 = users[i].Match31 += "c";
                    }
                }
                if (x > 31)
                {
                    var pointsToAdd = CalcMethod(users[i].Match32, results[31].name);
                    if (pointsToAdd > 0)
                    {
                        users[i].Points += pointsToAdd;
                        users[i].Match32 = users[i].Match32 += "c";
                    }
                }
                if (x > 32)
                {
                    var pointsToAdd = CalcMethod(users[i].Match33, results[32].name);
                    if (pointsToAdd > 0)
                    {
                        users[i].Points += pointsToAdd;
                        users[i].Match33 = users[i].Match33 += "c";
                    }
                }
                if (x > 33)
                {
                    var pointsToAdd = CalcMethod(users[i].Match34, results[33].name);

                    if (pointsToAdd > 0)
                    {
                        users[i].Points += pointsToAdd;
                        users[i].Match34 = users[i].Match34 += "c";
                    }
                }
                if (x > 34)
                {
                    var pointsToAdd = CalcMethod(users[i].Match35, results[34].name);
                    if (pointsToAdd > 0)
                    {
                        users[i].Points += pointsToAdd;
                        users[i].Match35 = users[i].Match35 += "c";
                    }
                }
                if (x > 35)
                {
                    var pointsToAdd = CalcMethod(users[i].Match36, results[35].name);
                    if (pointsToAdd > 0)
                    {
                        users[i].Points += pointsToAdd;
                        users[i].Match36 = users[i].Match36 += "c";
                    }
                }





                #endregion

                context.User.Update(users[i]);
                context.SaveChanges();
            }
        }

        private int CalcMethod(string bet, string result)
        {
            var points = 0;
            //check if bet has been evaluated before, if so, bet length is 4.
            if (bet.Length == 3)
            {
                if (bet == result) //check if bet is total correct
                    points += 10;
                else
                {
                    var x = result.ToCharArray();  //splits the current results into char array

                    var resH = Convert.ToInt32(x[0]); //takes out the results and bets value and places them in  variable
                    var resA = Convert.ToInt32(x[2]); // Making it possible to evaluate below
                    var betH = Convert.ToInt32(bet[0]);
                    var betA = Convert.ToInt32(bet[2]);

                    //Giving out points if the whole bet is not correct but other stats is.
                    if (resH > resA && betH > betA)
                        points += 5;

                    if (resH < resA && betH < betA)
                        points += 5;

                    if (resH == resA && betH == betA)
                        points += 5;
                    else
                    {
                        if (resH == betH)
                            points += 2;

                        if (resA == betA)
                            points += 2;
                    }
                }
            }
            return points;
        }

        private int CalcMethodOnAdv(string bet, string result)
        {
            int points = 0;

            if (result == "Mästare")
            {
                if (bet == result)
                    points = 15;
                if (bet == "Final")
                    points = 8;
                if (bet == "Semifinal")
                    points = 6;
                if (bet == "Kvartsfinal")
                    points = 4;
                if (bet == "Åttondelsfinal")
                    points = 2;
            }
            if (result == "Final")
            {
                if (bet == result)
                    points = 10;
                if (bet == "Mästare")
                    points = 8;
                if (bet == "Semifinal")
                    points = 6;
                if (bet == "Kvartsfinal")
                    points = 4;
                if (bet == "Åttondelsfinal")
                    points = 2;
            }
            if (result == "Semifinal")
            {
                if (bet == result)
                    points = 8;
                if (bet == "Final")
                    points = 6;
                if (bet == "Mästare")
                    points = 6;
                if (bet == "Kvartsfinal")
                    points = 4;
                if (bet == "Åttondelsfinal")
                    points = 2;
            }
            if (result == "Kvartsfinal")
            {
                if (bet == result)
                    points = 6;
                if (bet == "Final")
                    points = 4;
                if (bet == "Semifinal")
                    points = 4;
                if (bet == "Kvartsfinal")
                    points = 4;
                if (bet == "Åttondelsfinal")
                    points = 2;
            }
            if (result == "Åttondelsfinal")
            {
                if (bet == result)
                    points = 4;
                if (bet == "Final")
                    points = 2;
                if (bet == "Semifinal")
                    points = 2;
                if (bet == "Kvartsfinal")
                    points = 2;
                if (bet == "Åttondelsfinal")
                    points = 2;
            }
            if (result == "Gruppspel" && result == bet)
                points = 1;


            return points;
        }


    }
}


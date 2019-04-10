using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Calculate
{
    [TestFixture]
    public class FriendshipTest
    {
        Vasya vasyok;
        Friend fr1;
        Friend fr2;
        Friend fr3;
        Friend fr4;

        [SetUp]
        public void SetUpTestData()
        {
            vasyok = new Vasya();
            fr1 = new Friend();
            fr2 = new Friend();
            fr3 = new Friend();
            fr4 = new Friend();

            /*
            ArrayList friends = new ArrayList();
            for (int i = 0; i < friendsAmount; i++)
            {
                friends.Add(new Friend());
            }
            Console.WriteLine(friends.Count);
            */
        }

        [TearDown]
        public void KillAll()
        {
            vasyok = null;
            fr1 = null;
            fr2 = null;
            fr3 = null;
            fr4 = null;
        }

        [TestCase(100, 3, 4, 4, 7, -33)]
        public void VasyaVSFriends(

            double whaterHasVacya,
            double litPerDayByVacya,
            double litPerDayByFriend,
            int friendsAmount,
            int days,
            double drunk
            )
        {   
            vasyok.water = whaterHasVacya;
            double friendsDrinkWater = 0;

            for (int i = 0; i < days; i++)
            {
                vasyok.VasyaDrink(litPerDayByVacya);
                fr1.Drink(litPerDayByFriend);
                friendsDrinkWater += litPerDayByFriend;
                fr2.Drink(litPerDayByFriend);
                friendsDrinkWater += litPerDayByFriend;
                fr3.Drink(litPerDayByFriend);
                friendsDrinkWater += litPerDayByFriend;
                fr4.Drink(litPerDayByFriend);
                friendsDrinkWater += litPerDayByFriend;
            }
            vasyok.water = vasyok.water - friendsDrinkWater;

            Assert.AreEqual(drunk, vasyok.water);
            //Assert.AreEqual(new Exception("Friends drink too much!"), vasyok.IsWaterFinished());
        }


        [Test]
        public void Test()
        {
            Vasya vasyok = new Vasya();
            Friend fr1 = new Friend();
            Friend fr2 = new Friend();
            Friend fr3 = new Friend();
            vasyok.apples = 27;
            vasyok.VasyaEat(3);
            Console.WriteLine(vasyok.apples);
            //vasyok.apples = vasyok.apples - 3;

            double applesForEachFriend = new CalcCore().DivideMethod(vasyok.apples, 3);
            fr1.Eat(applesForEachFriend);
            fr2.Eat(applesForEachFriend);
            fr3.Eat(applesForEachFriend);

            double eatenApples = new CalcCore().PlusMethod(fr1.hasEat, fr2.hasEat);
            Console.WriteLine(eatenApples);
            eatenApples = new CalcCore().PlusMethod(eatenApples, fr3.hasEat);


            vasyok.apples = new CalcCore().MinusMethod(vasyok.apples, eatenApples);
            double er = 0;
            Assert.AreEqual(er, vasyok.apples);
        }



        [Test]
        public void VasyaEatDrink()
        {
            Vasya vasyok = new Vasya();
            vasyok.apples = 27;
            vasyok.water = 100;

            for (int i = 0; i < 7; i++)
            {
                vasyok.VasyaEat(3);
                vasyok.VasyaDrink(3);
            }

            double expect_apples = 6;
            double expect_waters = 79;

            Assert.AreEqual(expect_apples, vasyok.apples);
            Assert.AreEqual(expect_waters, vasyok.water);

        }

        [Test]
        public void VasyaVSFriendsEatDrink()
        {
            Vasya vasyok = new Vasya();
            Friend fr1 = new Friend();
            Friend fr2 = new Friend();
            Friend fr3 = new Friend();
            Friend fr4 = new Friend();

            vasyok.apples = 27;
            vasyok.water = 100;

            for (int i = 0; i < 7; i++)
            {
                vasyok.VasyaEat(3);
            }

            double applesForFriends = vasyok.apples;
            applesForFriends = new CalcCore().DivideMethod(applesForFriends, 4);

            double friendsDrinkWater = 0;

            for (int i = 0; i < 7; i++)
            {
                vasyok.VasyaDrink(3);
                fr1.Drink(4);
                friendsDrinkWater += 4;
                fr2.Drink(4);
                friendsDrinkWater += 4;
                fr3.Drink(4);
                friendsDrinkWater += 4;
                fr4.Drink(4);
                friendsDrinkWater += 4;
            }

            double friendsEatApples = 0;

            fr1.Eat(applesForFriends);
            friendsEatApples += applesForFriends;
            fr2.Eat(applesForFriends);
            friendsEatApples += applesForFriends;
            fr3.Eat(applesForFriends);
            friendsEatApples += applesForFriends;
            fr4.Eat(applesForFriends);
            friendsEatApples += applesForFriends;

            vasyok.apples -= friendsEatApples;
            vasyok.water -= friendsDrinkWater;

            Assert.AreEqual(0, vasyok.apples);
            Assert.AreEqual(-33, vasyok.water);
        }

        [Test]

        public void FriendsEatDrink()
        {
            Vasya vasyok = new Vasya();
            Friend fr1 = new Friend();
            Friend fr2 = new Friend();
            Friend fr3 = new Friend();
            Friend fr4 = new Friend();

            vasyok.apples = 27;
            vasyok.water = 100;

            double applesForFriends = vasyok.apples;
            applesForFriends = new CalcCore().DivideMethod(applesForFriends, 4);

            double friendsEatApples = 0;

            fr1.Eat(applesForFriends);
            friendsEatApples += applesForFriends;
            fr2.Eat(applesForFriends);
            friendsEatApples += applesForFriends;
            fr3.Eat(applesForFriends);
            friendsEatApples += applesForFriends;
            fr4.Eat(applesForFriends);
            friendsEatApples += applesForFriends;

            vasyok.apples -= friendsEatApples;

            double friendsDrinkWater = 0;

            for (int i = 0; i < 7; i++)
            {
                fr1.Drink(4);
                friendsDrinkWater += 4;
                fr2.Drink(4);
                friendsDrinkWater += 4;
                fr3.Drink(4);
                friendsDrinkWater += 4;
                fr4.Drink(4);
                friendsDrinkWater += 4;
            }

            vasyok.water -= friendsDrinkWater;

            Assert.AreEqual(0, vasyok.apples);
            Assert.AreEqual(-12, vasyok.water);
        }
    }
}

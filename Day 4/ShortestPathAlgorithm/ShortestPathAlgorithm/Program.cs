using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPathAlgorithm
{
    class Program
    {



        static void Main(string[] args)
        {
            CreateMapAdjList();
        }
        public static void CreateMapAdjList()
        {
            Vertex<string> KiryatShemona = new Vertex<string>("KiryatShemona");
            Vertex<string> Nahariya = new Vertex<string>("Nahariya");
            Vertex<string> Tiberias = new Vertex<string>("Tiberias");
            Vertex<string> Haifa = new Vertex<string>("Haifa");
            Vertex<string> Nathareth = new Vertex<string>("Nathareth");
            Vertex<string> Netanya = new Vertex<string>("Netanya");
            Vertex<string> Tel_Aviv = new Vertex<string>("Tel_Aviv");
            Vertex<string> Rishon = new Vertex<string>("Rishon");
            Vertex<string> Jerusalem = new Vertex<string>("Jerusalem");
            Vertex<string> Bet_Shemesh = new Vertex<string>("Bet_Shemesh");
            Vertex<string> Ashkelon = new Vertex<string>("Ashkelon");
            Vertex<string> Mitzpe_Ramon = new Vertex<string>("Mitzpe_Ramon");
            Vertex<string> Beer_Sheva = new Vertex<string>("Beer_Sheva");
            Vertex<string> Dimona = new Vertex<string>("Dimona");
            Vertex<string> Eilat = new Vertex<string>("Eilat");
            AdjacencyList<string> myMap = new AdjacencyList<string>();
            //-------
            Nahariya.AddEdge(KiryatShemona, 55);
            Nahariya.AddEdge(Haifa, 25);
            Nahariya.AddEdge(Jerusalem, 135);
            //-------
            KiryatShemona.AddEdge(Tiberias, 45);
            //-------
            Tiberias.AddEdge(Haifa, 50);
            Tiberias.AddEdge(Nathareth, 26);
            //-------
            Haifa.AddEdge(Nathareth, 35);
            Haifa.AddEdge(Netanya, 52);
            //-------
            Nathareth.AddEdge(Netanya, 57);
            //-------
            Netanya.AddEdge(Tel_Aviv, 31);
            //-------
            Tel_Aviv.AddEdge(Rishon, 15);
            Tel_Aviv.AddEdge(Beer_Sheva, 90);
            Tel_Aviv.AddEdge(Eilat, 280);
            //-------
            Jerusalem.AddEdge(Rishon, 34);
            Jerusalem.AddEdge(Beer_Sheva, 65);
            Jerusalem.AddEdge(Dimona, 75);
            //-------
            Rishon.AddEdge(Bet_Shemesh, 30);
            Rishon.AddEdge(Ashkelon, 40);
            //-------
            Bet_Shemesh.AddEdge(Beer_Sheva, 55);
            //-------
            Ashkelon.AddEdge(Beer_Sheva, 48);
            //-------
            Beer_Sheva.AddEdge(Dimona, 30);
            Beer_Sheva.AddEdge(Mitzpe_Ramon, 68);
            //-------
            Mitzpe_Ramon.AddEdge(Eilat, 120);




        }
        public static void CreateMapAdjMatix()
        {
            AdjacencyMatrix myAdjMat = new AdjacencyMatrix(15);
            //-------
            myAdjMat.AddAdge(Cities.Nahariya, Cities.KiryatShemona, 55);
            myAdjMat.AddAdge(Cities.Nahariya, Cities.Haifa, 25);
            myAdjMat.AddAdge(Cities.Nahariya, Cities.Jerusalem, 135);
            //-------
            myAdjMat.AddAdge(Cities.KiryatShemona, Cities.Tiberias, 45);
            //-------
            myAdjMat.AddAdge(Cities.Tiberias, Cities.Haifa, 50);
            myAdjMat.AddAdge(Cities.Tiberias, Cities.Nathareth, 26);
            //-------
            myAdjMat.AddAdge(Cities.Haifa, Cities.Nathareth, 35);
            myAdjMat.AddAdge(Cities.Haifa, Cities.Netanya, 52);
            //-------
            myAdjMat.AddAdge(Cities.Nathareth, Cities.Netanya, 55);
            //-------
            myAdjMat.AddAdge(Cities.Netanya, Cities.Tel_Aviv, 55);
            //-------
            myAdjMat.AddAdge(Cities.Tel_Aviv, Cities.Rishon, 55);
            myAdjMat.AddAdge(Cities.Tel_Aviv, Cities.Beer_Sheva, 55);
            myAdjMat.AddAdge(Cities.Tel_Aviv, Cities.Eilat, 55);
            //-------
            myAdjMat.AddAdge(Cities.Jerusalem, Cities.Rishon, 55);
            myAdjMat.AddAdge(Cities.Jerusalem, Cities.Beer_Sheva, 55);
            myAdjMat.AddAdge(Cities.Jerusalem, Cities.Dimona, 55);
            //-------
            myAdjMat.AddAdge(Cities.Rishon, Cities.Bet_Shemesh, 55);
            myAdjMat.AddAdge(Cities.Rishon, Cities.Ashkelon, 55);
            //-------
            myAdjMat.AddAdge(Cities.Bet_Shemesh, Cities.Beer_Sheva, 55);
            //-------
            myAdjMat.AddAdge(Cities.Ashkelon, Cities.Beer_Sheva, 55);
            //-------
            myAdjMat.AddAdge(Cities.Beer_Sheva, Cities.Mitzpe_Ramon, 55);
            myAdjMat.AddAdge(Cities.Beer_Sheva, Cities.Dimona, 55);
            //-------
            myAdjMat.AddAdge(Cities.Nahariya, Cities.Haifa, 55);
            myAdjMat.AddAdge(Cities.Nahariya, Cities.Haifa, 55);
            myAdjMat.AddAdge(Cities.Nahariya, Cities.Haifa, 55);
            myAdjMat.AddAdge(Cities.Nahariya, Cities.Haifa, 55);
            myAdjMat.AddAdge(Cities.Nahariya, Cities.Haifa, 55);
            myAdjMat.AddAdge(Cities.Nahariya, Cities.Haifa, 55);

        }
    }
}

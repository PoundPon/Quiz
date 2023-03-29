using System;
namespace Code {
    class Program{
         static string result(int N, int gender) {
           Console.WriteLine("{0} {1}", N, gender);
        }
        static string choose(int gender, int Score1, int Score2) {
            if (Score1 > 8){
                if (gender == 1){
                    K1 = K1 - 1;
                }
            }
            else if (Score2 > 8){
                if (gender == 2){
                    K2 = K2 - 1;
                }
            }
        }
        static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            if ((N > 1 || N <=10000) && (K > 1 || K <= 1000)){
                int K1 = K;
                int K2 = K;
                int Kall;
                while(Kall != 0){ 
                    int gender = int.Parse(Console.ReadLine());
                    int Score1 = int.Parse(Console.ReadLine());
                    int Score2 = int.Parse(Console.ReadLine());
                    Kall = K1 + K2;

                }
               
                
            }
        }
    }
}

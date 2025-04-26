using System.Collections.Generic;

public class HandShake{
    public static void Run(){

        TextWriter textWriter = Console.Out;

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int result = HandShake.handshake(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }

    public static int handshake(int n){
        //n é o numero de pessoas
        //Essa funcao tem que retornar o numero de apertos de mao que vao ser dados na sala
        //Quando for a primeira pessoa, o numero de apertos vai ser apertos += (n - 1)

        int apertos = 0;
        if(n == 0 || n == 1){
            return apertos;
        }else{
            for(int i=0;i<n;i++){
                apertos += i;
            }
            return apertos;
        }
    } 
}
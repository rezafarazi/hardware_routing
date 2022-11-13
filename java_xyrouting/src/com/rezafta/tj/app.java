package com.rezafta.tj;

import java.util.*;

public class app
{

    public static void main(String []args)
    {
        Scanner scn=new Scanner(System.in);
        
        System.out.print("Enter count of x : ");
        int x = scn.nextInt();
        System.out.print("Enter count of y : ");
        int y = scn.nextInt();

        System.out.print("Enter current x location : ");
        int cureent_x= scn.nextInt();
        System.out.print("Enter current y location : ");
        int cureent_y = scn.nextInt();

        System.out.print("Enter target x location : ");
        int target_x = scn.nextInt();
        System.out.print("Enter target y location : ");
        int target_y = scn.nextInt();

        while(true)
        {
            ArrayList<Integer> result = route(x, y, cureent_x, cureent_y, target_x, target_y);
            System.out.println(result.get(0));
            System.out.println(result.get(1));
            cureent_x = result.get(0);
            cureent_y = result.get(1);
            if (cureent_x == target_x && cureent_y == target_y)
                break;
        }
    }


    //Route function Start
    static ArrayList<Integer> route(int lenx, int leny, int current_x, int current_y, int target_x, int target_y)
    {

        if (current_x > target_x && current_x > 0)
            current_x-= 1;
        else if (current_x < target_x && current_x < lenx)
            current_x += 1;

        if (current_y > target_y && current_y > 0)
            current_y -= 1;
        else if (current_y < target_y && current_y < leny)
            current_y += 1;

        ArrayList<Integer> result = new ArrayList<Integer>();
        result.add(current_x);
        result.add(current_y);

        return result;
    }
    //Route function End

}

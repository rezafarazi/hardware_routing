#Rezafta

#One step route function Start
def route(lenx,leny,current_x,current_y,target_x,target_y):

    if(current_x>target_x and current_x>0):
        current_x-=1
    elif(current_x<target_x and current_x<lenx):
        current_x+=1

    if(current_y>target_y and current_y>0):
        current_y-=1
    elif(current_y<target_y and current_y<leny):
        current_y+=1

    return current_x,current_y
#One step route function End


#Main Function Start
def main():

    x=int(input("Enter count of x : "))
    y=int(input("Enter count of y : "))

    cureent_x=int(input("Enter current x location : "))
    cureent_y=int(input("Enter current y location : "))

    target_x=int(input("Enter target x location : "))
    target_y=int(input("Enter target y location : "))

    while(1==1):
        cureent_x , cureent_y = route(x,y,cureent_x,cureent_y,target_x,target_y)
        print(cureent_x)
        print(cureent_y)
        if cureent_x==target_x and cureent_y==target_y :
            break
        
if __name__=="__main__":
    main()
#Main Function End




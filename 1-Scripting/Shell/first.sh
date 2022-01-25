
# repeat start with true

repeat="true"
echo "what is your name?"
read  name
echo "hello, $name"

# while loop starts
while [ "$repeat" == true ]
do
echo "press 1 if you want to order a burger"
echo "press 2 if you want to order a pizza"
echo "press 3 if you want to order a sushi"
echo "press 4 if you want to exit the program"
read ans

if [ "$ans" == "1" ]
then 
echo "cheese burger or quarter pounder?"
read var1
echo "you have ordered $var1"
echo "press enter to continue"
read return

elif [ "$ans" == "2" ]
then
echo "vegi pizza or combination?"
read var2
echo "you have ordered $var2"
echo "press enter to continue"
read returns

elif [ "$ans" == "3" ]
then
echo "sushi or sashimi?"
read var3
echo "you have ordered $var3"
echo "press enter to continue"
read returnss

elif [ "$ans" == "4" ]
then 
echo "See you next time"
# to exit the program
repeat="false"
else "Command not found"
fi
# clear the terminal
clear
done




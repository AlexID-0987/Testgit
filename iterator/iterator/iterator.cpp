// iterator.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include<string>
#include<vector>

int main()
{
	std::vector<std::string>myVector = { "Resminov Alex ID76859430 Deli", "Revtov Stasha ID5465464 Parish",
		"Sidorov Fedul ID870689 Berlin","Petrow Rex ID897698 Warshawa" };
	
	
	for (std::vector<std::string>::iterator i = myVector.begin(); i != myVector.end(); i++)
	{
		std::cout << *i << std::endl;
		
	}
	std::vector<std::string>::iterator it;
	it = myVector.begin();
	it++;
	std::cout << *it << std::endl;
	it++;
	std::cout << *it << std::endl;
	it+=1;
	std::cout << *it << std::endl;
}


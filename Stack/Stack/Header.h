

#include<exception>
//#include<iostream>
#include <fstream> 
#include <stdlib.h> 







template <typename T>
struct Array
{
	Array() : _top(NULL), _size(0) {}
	struct Node
	{
		Node(T el) : data(el) {}
		Node(T el, Node* node) :data(el), next(node){}
		Node* next;
		T data;

	};

	void push(const T);
	void pop();
	T& top();
	int size();
	bool empty();
	void at();

	

private:
	Node* _top;
	int _size;
	std::string Task;
	std::string date, months, year, time;
	std::string Task_a;
	std::string date_a, months_a, year_a, time_a;
	std::string Task_b;
	std::string date_b, months_b, year_b, time_b;
	int a = 1, b = 2, c = 3,d=4, val=0, val_a=0,val_b=0;
	

};
template <typename T>
void Array<T>::push(const T el )
{
	try
	{
		if (_top != NULL)
		{
			Node* temp = new Node(el, _top);
			_top = temp;
			
		}
		else
		{
			/*
			std::cout << "Enter Task 1: " <<Task<< std::endl;
			std::cin >> Task;
			std::cout << "Enter Date: " << date << std::endl;
			std::cin >> date;
			std::cout << "Enter months: " << months << std::endl;
			std::cin >> months;
			std::cout << "Enter year: " << year << std::endl;
			std::cin >> year;
			std::cout << "Enter time: " << time << std::endl;
			std::cin>> time;
			std::cout << "Enter priority: 1 - high priority, 2 - medium priority, 3 - low priority!\n   "  << std::endl;
			std::cin >> val;

			if (val == a)
			{
				
				std::cout << "You priority high!"  << std::endl;
			}
			
			if (val == b)
				{
					std::cout << "You priority medium!" << std::endl;
				}
			if (val == c)
				{
					std::cout << "You priority low!" << std::endl;
				}
			if (val == d)
			{
				std::cout << "Not priority!!!" << std::endl;
			}

			std::cout << "Enter Task 2: " << Task_a << std::endl;
			std::cin >> Task_a;
			std::cout << "Enter Date: " << date_a << std::endl;
			std::cin >> date_a;
			std::cout << "Enter months: " << months_a << std::endl;
			std::cin >> months_a;
			std::cout << "Enter year: " << year_a << std::endl;
			std::cin >> year_a;
			std::cout << "Enter time: " << time_a << std::endl;
			std::cin >> time_a;
			std::cout << "Enter priority: 1 - high priority, 2 - medium priority, 3 - low priority!\n   " << std::endl;
			std::cin >> val_a;

			if (val_a == a)
			{

				std::cout << "You priority high!" << std::endl;
			}

			if (val_a == b)
			{
				std::cout << "You priority medium!" << std::endl;
			}
			if (val_a == c)
			{
				std::cout << "You priority low!" << std::endl;
			}
			if (val_a == d)
			{
				std::cout << "Not priority!!!" << std::endl;
			}

			
			std::cout << "Enter Task 3: " << Task_b << std::endl;
			std::cin >> Task_b;
			std::cout << "Enter Date: " << date_b << std::endl;
			std::cin >> date_b;
			std::cout << "Enter months: " << months_b << std::endl;
			std::cin >> months_b;
			std::cout << "Enter year: " << year_b << std::endl;
			std::cin >> year_b;
			std::cout << "Enter time: " << time_b << std::endl;
			std::cin >> time_b;
			std::cout << "Enter priority: 1 - high priority, 2 - medium priority, 3 - low priority!\n   " << std::endl;
			std::cin >> val_b;

			if (val_b == a)
			{

				std::cout << "You priority high!\n" << std::endl;
			}

			if (val_b == b)
			{
				std::cout << "You priority medium!\n" << std::endl;
			}
			if (val_b == c)
			{
				std::cout << "You priority low!\n" << std::endl;
			}
			if (val_b == d)
			{
				std::cout << "Not priority!!!\n" << std::endl;
			}

			std::cout << "Hello, Do not forget!\n" << std::endl;
			std::cout << "\t Task \t Data \t Months \t Year\t Time\n\n" << std::endl;
			std::cout << "Task 1: " << Task + "|" + '\t' + date + "|" + '\t' + months + "|"+ '\t' + year + "|" +'\t' + time +  "\n" << std::endl;
			std::cout << "You priority - " << val << std::endl;
			std::cout << "\nTask 2: " << Task_a + "|" + '\t' + date_a + "|" + '\t' + months_a + "|" + '\t' + year_a + "|" + '\t' + time_a + "\n" << std::endl;
			std::cout << "You priority - " << val_a << std::endl;
			std::cout << "\nTask 3: " << Task_b + "|" + '\t' + date_b + "|" +'\t' + months_b + "|" + '\t' + year_b + "|" + '\t' + time_b + "\n" << std::endl;
			std::cout << "You priority - " << val_b << std::endl;
			*/
			_top = new Node(Task + '\t' + date + '\t' + months + '\t' + year + '\t' + time + "\n");
			_top = new Node(Task_a + '\t' + date_a + '\t' + months_a + '\t' + year_a + '\t' + time_a + "\n");
			_top = new Node(Task_b + '\t' + date_b + '\t' + months_b + '\t' + year_b + '\t' + time_b + "\n");
			_top = new Node(el);
			
		}
		_size++;
	}
	catch (std::bad_alloc)
	{
		std::cout << "std::bad_alloc" << std::endl;
	}
}

template <typename T>
void Array<T>::pop()
{
	try
	{
		if (_top == NULL)
			throw std::out_of_range("Error: Out of range");
		Node* temp = _top;
		_top = _top->next;
		delete temp;
		_size--;

	}
	catch (std::exception &e)
	{
		std::cout << e.what() << std::endl;
	}
}

template <typename T>
T& Array<T>::top()
{
	try
	{
		if (_top == NULL)
			throw std::out_of_range("Error: Stack is empty!");
		return _top->data;
	}
	catch (std::exception &e)
	{
		std::cout << e.what() << std::endl;
	}
}


template <typename T>
int Array<T>::size()
{
	
	return _size;
}
template <typename T>
bool Array<T>::empty()
{
	return _size == 0 ? true : false;
}






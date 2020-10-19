

#include "Header.h"
#include <thread>
void part_two()
{
	INFO("Error; Line4");
}
int main()
{
	INFO("Error;Line9");

	std::thread second_thread(part_two);
	second_thread.join();
	ERROR("Error,Error;Line23");
}

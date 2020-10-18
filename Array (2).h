#ifndef ARRAY_H
#define ARRAY_H

template<typename T>
class Array
{
private:
	T*data;
	size_t cnt;
	size_t _size;
public:
	Array() :cnt(4), _size(0) { data = new T[cnt]; };
	~Array()
	{
		delete[]data;
	};
	void push_back(T value)
	{
		if (_size + 1 >= cnt)
		{
			T*buffer = new T[cnt];
			for (size_t i = 0; i < cnt;i++)
				buffer[i] = data[i];
			cnt *= 4;
			delete[]data;
			data = new T[cnt];
			for (size_t i = 0; i < _size; i++)
				data[i] = buffer[i];
			delete[]buffer;
		}
		data[_size++] = value;
	}
	T & operator[](size_t place)
	{
		return data[place];
	}
	void empty()
	{
		if (_size == 0)
		{
			std::cout << "Array empty!" << std::endl;
		}
		else
		{
			std::cout << "Array not empty!" << std::endl;
		}
	}
	
	void max_size()
	{
		
		
			std::cout << "Max size:" << _size << std::endl;
	}
	void size()
	{
		
		std::cout << "Size: " <<_size<< std::endl;
	}
	void at()
	{
		for (size_t i = 0; i < _size; i++)
		{
			
			std::cout << "At:" << data[i] << " ";
		}
		
	}
	void resize(int c)
	{
		_size = c;
		cnt = c;
		T*buffer = new T[_size];
		for (size_t i = 0; i < _size; i++)
		{
			buffer[i] = data[i];


		}
		delete[]data;
		data = new T[cnt]{ 0 };
		for (size_t i = 0; i < _size; i++)
		{
			data[i] = buffer[i];
			std::cout << "Resize:" << data[i] << std::endl;
		}
		delete[]buffer;
	}
		/*
		void swap(T*& data2)
		{
			T * buffer = new T[_size];
			for (size_t i = 0; i < _size; i++)
			{
				buffer[i] = data[i];
			}
			for (size_t i < 0; i < _size; i++)
			{
				data[i] = data2[i];
			}
			for (size_t i < 0; i < _size; i++)
			{
				data2[i] = data[i];
			}
			delete[]buffer;
		}
	
		*/

	void pop_back()
	{
		data[_size-1]==0;
		 _size--;
		 std::cout << "Pop:" << _size-- << std::endl;
	}
	/*
	void emplace_back(T value) {
		if ((_size + 1) % 4 == 0) {
			T* buffer = new T[size];
			for (size_t i = 0; i < _size; i++) {
				buffer[i] = data[i];
			}
			delete[]data;
			cnt = _size + 5;
			data = new T[cnt]{ 0 };
			for (size_t i = 0; i < _size; i++) {
				data[i] = buffer[i];
			}
			delete[]buffer;
		}
		data[_size] = value;
		_size++;

	*/

	void clear()
	{
		delete[]data;
		data = new T[cnt];
		_size = 0;
		cnt = 9;
		
	}
	/*

	void reserve()
	{
		for (size_t i = 0; i < _size; i++) {
			if ((data + i)  == 0)
			{
				T* buffer = new T[cnt];
				for (size_t i = 0; i < _size; i++) {
					buffer[i] = data[i];
				}
				delete[]data;
				data = new T[cnt + i + 4]{ 0 };
				for (size_t i = 0; i < _size; i++) {
					data[i] = buffer[i];
				}
				delete[]buffer;
				
			}
			
		}

	}
	*/

};


#endif // !ARRAY




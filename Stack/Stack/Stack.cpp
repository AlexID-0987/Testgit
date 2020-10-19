

#include<exception>
#include<iostream>

 





template <typename T>
 struct Stack
{
	Stack () : _top (NULL), _size(0){}
	struct Node
	{
		Node (T el) : data(el){}
		Node (T el, Node* node):data(el),next(node){}
		Node* next;
		T data;
	};

	void push(const T);
	void pop();
	T& top();
	int size();
	bool empty();

private:
	Node* _top;
	int _size;

};
 template <typename T>
 void Stack<T>:: push (const T el)
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
 void Stack<T>::pop()
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
 T& Stack<T>::top()
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
 int Stack<T>::size()
 {
	 return _size;
 }
 template <typename T>
 bool Stack<T>::empty()
 {
	 return _size == 0 ? true : false;
 }

 

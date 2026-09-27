# 1 Why is a single 20-parameter constructor for this class a problem in practice? Think about call-site
# readability, the risk of passing two values in the wrong order (e.g. two decimal amounts, or two strings that

 multiple parameters in a constructor can lead to problems when initializing an object
 we may forget the order of the parameters especially when multiple parameters have the same type
 which lead to incorrect results.

Also a long constructor is difficult to read and understand 


# 2 Is this purely a "constructor is too long" problem, or is there a deeper design issue with putting ~20 loosely
# related properties on a single class in the first place?

Each class should contain related fields and methods that serve one main purpose
dividing a large class into smaller classes where each class has its own related data and responsibility
is better than having one large class with many loosely related properties.


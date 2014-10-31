FactoryByReflection
===================

Base Factory class to create object using System.Reflection: **Jebur27.FactoryBase**

Includes two sample projects: 

1. **Jebur27.Security** - Contains two Security Manger classes and a Security Manager factory;
2. **Jebur27.Security.Factory** - Contains a Security Manager factory alone. 


**All** projects are covered by Unit Test projects 100% coverage.


##Jebur27.FactoryBase Project
Contains two classes:

- **BaseFactory** - Abstract class which is inherited by specific factory classes; 
- **TypeNotFoundFactoryException** - May be used by child classes to indicate that a type that the child factory is trying to create could not be found. 



##Jebur27.Security
Contains three classes and one interface:

- **ISecurityManager** - Interface for Security Managers; 
- **SecurityManagerOne** - A class stub that implements the ISecurityManager; 
- **SecurityManagerTwo** - A class stub that implements the ISecurityManager; 
- **SecurityFactory** - A factory based on the BaseFactory that creates an ISecurityManager object depending on the inputs. This factory also throws TypeNotFoundFactoryException if the type does not exist. 


##Jebur27.Security.Factory
Contains one class:

- **Factory** - A factory based on the BaseFactory that creates an ISecurityManager object depending on the inputs. This factory also throws TypeNotFoundFactoryException if the type does not exist. 




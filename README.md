# Learn Design Patterns

## Creational Patterns: How objects are created

### 1. Singleton:
Singleton is a creational design pattern that lets you ensure that a class has only one instance, while providing a global access point to this instance.

_**Keyword:** Single instance_

### 2. Prototype:
Prototype is a creational design pattern that allows cloning objects, even complex ones, without coupling to their specific classes.

_**Keyword:** Cloning / Copying_

### 3. Builder:
Builder is a creational design pattern that lets you construct complex objects step by step. The pattern allows you to produce different types and representations of an object using the same construction code.

_**Keyword:** Step by step_

### 4. Factory Method:
Factory Method is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created. In simple terms, the Factory defines a method, which should be used for creating objects instead of using a direct constructor call (new operator).

_**Keyword:** A create method_

## Structural Patterns: How objects relate to each other

### 1. Facade:
Facade is a structural design pattern that provides a simplified (but limited) interface to a complex system of classes, library or framework.

_**Keyword:** A simple interface_

### 2. Proxy:
Proxy is a structural design pattern that provides an object that acts as a substitute for a real service object used by a client. A proxy receives client requests, does some work (access control, caching, etc.) and then passes the request to a service object.

_**Keyword:** Substitute_

## Behavioral Patterns: How objects communicate with each other

### 1. Observer:
Observer is a behavioral design pattern that allows some objects to notify other objects about changes in their state.

_**Keyword:** Subscribe and notify_
# SymbioticBaseList&lt;TList, TItem&gt;

Namespace: symbolist

Represents the base behavior for a symbiotic list

```csharp
public abstract class SymbioticBaseList<TList, TItem> : IReadOnlyList`1, IReadOnlyCollection`1, IEnumerable`1, System.Collections.IEnumerable where TList : SymbioticBaseList<TList, TItem> where TItem : SymbioticItem<TList, TItem>
```

#### Type Parameters

`TList`<br>

`TItem`<br>

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [SymbioticBaseList&lt;TList, TItem&gt;](https://github.com/blackrookgames/symbolist/tree/main/symbolist/docs/1.0.0/symbolist.symbioticbaselist-2.md)<br>
Implements IReadOnlyList&lt;TItem&gt;, IReadOnlyCollection&lt;TItem&gt;, IEnumerable&lt;TItem&gt;, [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable)<br>
Attributes [NullableContextAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullablecontextattribute), [NullableAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullableattribute), [DefaultMemberAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.defaultmemberattribute)

## Properties

### **Capacity**

List capacity

```csharp
public int Capacity { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **Count**

Number of items in list

```csharp
public int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>

## Indexers

### **this[Int32]**

```csharp
public TItem this[int index] { get; }
```

#### Parameters

`index` [Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>

#### Property Value

TItem<br>

## Constructors

### **SymbioticBaseList()**

Initializer for [SymbioticBaseList&lt;TList, TItem&gt;](https://github.com/blackrookgames/symbolist/tree/main/symbolist/docs/1.0.0/symbolist.symbioticbaselist-2.md)

```csharp
public SymbioticBaseList()
```

### **SymbioticBaseList(Int32)**

Initializer for [SymbioticBaseList&lt;TList, TItem&gt;](https://github.com/blackrookgames/symbolist/tree/main/symbolist/docs/1.0.0/symbolist.symbioticbaselist-2.md)

```csharp
public SymbioticBaseList(int capacity)
```

#### Parameters

`capacity` [Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>
List inital capacity

#### Exceptions

[ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)<br>
`capacity` is negative

## Methods

### **EnsureCapacity(Int32)**

Expands the list capacity to ensure it is at least the specified minimum

```csharp
protected int EnsureCapacity(int capacity)
```

#### Parameters

`capacity` [Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>
Minimum list capacity

#### Returns

[Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>
New list capacity

#### Exceptions

[ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)<br>
`capacity` is negative

### **TrimExcess()**

Shrinks the list capacity to the actual number of items in the list

```csharp
protected void TrimExcess()
```

### **CanAdd(TItem)**

Checks whether or not the specified item can be added to the list

```csharp
protected bool CanAdd(TItem item)
```

#### Parameters

`item` TItem<br>
Item to add

#### Returns

[Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Whether or not the specified item can be added to the list

#### Exceptions

[ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>
`item` is null

### **CanRemove(TItem)**

Checks whether or not the specified item can be removed from the list

```csharp
protected bool CanRemove(TItem item)
```

#### Parameters

`item` TItem<br>
Item to remove

#### Returns

[Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Whether or not the specified item can be removed from the list

#### Exceptions

[ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>
`item` is null

### **TryAdd(TItem)**

Attempts to add the specified item to the list

```csharp
protected bool TryAdd(TItem item)
```

#### Parameters

`item` TItem<br>
Item to add

#### Returns

[Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Whether or not successful

#### Exceptions

[ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>
`item` is null

### **TryInsert(Int32, TItem)**

Attempts to insert the specified item into the list

```csharp
protected bool TryInsert(int index, TItem item)
```

#### Parameters

`index` [Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>
Index to insert item

`item` TItem<br>
Item to insert

#### Returns

[Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Whether or not successful

#### Exceptions

[ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)<br>
`index` is out of range

[ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>
`item` is null

### **TryRemove(TItem)**

Attempts to remove the specified item from the list

```csharp
protected bool TryRemove(TItem item)
```

#### Parameters

`item` TItem<br>
Item to remove

#### Returns

[Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Whether or not successful

#### Exceptions

[ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>
`item` is null

### **TryRemove(Int32)**

Attempts to remove the item at the specified index from the list

```csharp
protected bool TryRemove(int index)
```

#### Parameters

`index` [Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>
Index of item

#### Returns

[Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Whether or not successful

#### Exceptions

[ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)<br>
`index` is out of range

### **TryClear()**

Attempts to remove all items from the list

```csharp
protected bool TryClear()
```

#### Returns

[Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Whether or not all items were removed from the list

### **Add(TItem)**

Adds the specified item to the list

```csharp
protected void Add(TItem item)
```

#### Parameters

`item` TItem<br>
Item to add

#### Exceptions

[ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>
`item` is null

[SymbioticException](https://github.com/blackrookgames/symbolist/tree/main/symbolist/docs/1.0.0/symbolist.symbioticexception.md)<br>
`item` could not be added to list

### **Insert(Int32, TItem)**

Inserts the specified item into the list

```csharp
protected void Insert(int index, TItem item)
```

#### Parameters

`index` [Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>
Index to insert item

`item` TItem<br>
Item to insert

#### Exceptions

[ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)<br>
`index` is out of range

[ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>
`item` is null

[SymbioticException](https://github.com/blackrookgames/symbolist/tree/main/symbolist/docs/1.0.0/symbolist.symbioticexception.md)<br>
`item` could not be added to list

### **Remove(TItem)**

Removes the specified item from the list

```csharp
protected void Remove(TItem item)
```

#### Parameters

`item` TItem<br>
Item to remove

#### Exceptions

[ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>
`item` is null

[SymbioticException](https://github.com/blackrookgames/symbolist/tree/main/symbolist/docs/1.0.0/symbolist.symbioticexception.md)<br>
`item` could not be removed from list

### **Remove(Int32)**

Removes the item at the specified index from the list

```csharp
protected void Remove(int index)
```

#### Parameters

`index` [Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>
Index of item to remove

#### Exceptions

[ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)<br>
`index` is null

[SymbioticException](https://github.com/blackrookgames/symbolist/tree/main/symbolist/docs/1.0.0/symbolist.symbioticexception.md)<br>
Item at `index` could not be removed from list

### **Clear()**

Removes all items from the list

```csharp
protected void Clear()
```

#### Exceptions

[SymbioticException](https://github.com/blackrookgames/symbolist/tree/main/symbolist/docs/1.0.0/symbolist.symbioticexception.md)<br>
One or more items could not be removed from the list

### **CanBeAdded(TItem)**

Implementer-defined checks on whether or not the specified item can be added to the list

```csharp
protected virtual bool CanBeAdded(TItem item)
```

#### Parameters

`item` TItem<br>
Item to add

#### Returns

[Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Whether or not the specified item can be added to the list

### **CanBeRemoved(TItem)**

Implementer-defined checks on whether or not the specified item can be removed from the list

```csharp
protected virtual bool CanBeRemoved(TItem item)
```

#### Parameters

`item` TItem<br>
Item to remove

#### Returns

[Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Whether or not the specified item can be removed to the list

### **PreAdd(TItem)**

Called before the specified item is added to the list

```csharp
protected virtual void PreAdd(TItem item)
```

#### Parameters

`item` TItem<br>
Item to add

### **PostAdd(TItem)**

Called after the specified item is added to the list

```csharp
protected virtual void PostAdd(TItem item)
```

#### Parameters

`item` TItem<br>
Added item

### **PreRemove(TItem)**

Called before the specified item is removed from the list

```csharp
protected virtual void PreRemove(TItem item)
```

#### Parameters

`item` TItem<br>
Item to remove

### **PostRemove(TItem)**

Called after the specified item is removed from the list

```csharp
protected virtual void PostRemove(TItem item)
```

#### Parameters

`item` TItem<br>
Removed item

### **GetEnumerator()**

Gets an enumerator thru the list items

```csharp
public IEnumerator<TItem> GetEnumerator()
```

#### Returns

IEnumerator&lt;TItem&gt;<br>
Enumerator thru the list items

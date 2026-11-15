# SymbioticList&lt;TList, TItem&gt;

Namespace: symbolist

Represents a symbiotic list

```csharp
public abstract class SymbioticList<TList, TItem> : SymbioticBaseList`2, IReadOnlyList`1, IReadOnlyCollection`1, IEnumerable`1, System.Collections.IEnumerable where TList : SymbioticList<TList, TItem> where TItem : SymbioticItem<TList, TItem>
```

#### Type Parameters

`TList`<br>

`TItem`<br>

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → SymbioticBaseList&lt;TList, TItem&gt; → [SymbioticList&lt;TList, TItem&gt;](https://github.com/blackrookgames/symbolist/tree/main/symbolist/docs/1.0.0/symbolist.symbioticlist-2.md)<br>
Implements IReadOnlyList&lt;TItem&gt;, IReadOnlyCollection&lt;TItem&gt;, IEnumerable&lt;TItem&gt;, [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable)<br>
Attributes [NullableContextAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullablecontextattribute), [NullableAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullableattribute), [DefaultMemberAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.defaultmemberattribute)

## Properties

### **Capacity**

```csharp
public int Capacity { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **Count**

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

### **SymbioticList()**

Initializer for [SymbioticList&lt;TList, TItem&gt;](https://github.com/blackrookgames/symbolist/tree/main/symbolist/docs/1.0.0/symbolist.symbioticlist-2.md)

```csharp
public SymbioticList()
```

### **SymbioticList(Int32)**

Initializer for [SymbioticList&lt;TList, TItem&gt;](https://github.com/blackrookgames/symbolist/tree/main/symbolist/docs/1.0.0/symbolist.symbioticlist-2.md)

```csharp
public SymbioticList(int capacity)
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
public new int EnsureCapacity(int capacity)
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
public new void TrimExcess()
```

### **CanAdd(TItem)**

Checks whether or not the specified item can be added to the list

```csharp
public new bool CanAdd(TItem item)
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
public new bool CanRemove(TItem item)
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
public new bool TryAdd(TItem item)
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
public new bool TryInsert(int index, TItem item)
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
public new bool TryRemove(TItem item)
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

Attempts to remove the specified item from the list

```csharp
public new bool TryRemove(int index)
```

#### Parameters

`index` [Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>

#### Returns

[Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Whether or not successful

#### Exceptions

[ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>
`item` is null

### **TryClear()**

Attempts to remove all items from the list

```csharp
public new bool TryClear()
```

#### Returns

[Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Whether or not all items were removed from the list

### **Add(TItem)**

Adds the specified item to the list

```csharp
public new void Add(TItem item)
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
public new void Insert(int index, TItem item)
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
public new void Remove(TItem item)
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

Removes the specified item from the list

```csharp
public new void Remove(int index)
```

#### Parameters

`index` [Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>

#### Exceptions

[ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>
`item` is null

[SymbioticException](https://github.com/blackrookgames/symbolist/tree/main/symbolist/docs/1.0.0/symbolist.symbioticexception.md)<br>
`item` could not be removed from list

### **Clear()**

Removes all items from the list

```csharp
public new void Clear()
```

#### Exceptions

[SymbioticException](https://github.com/blackrookgames/symbolist/tree/main/symbolist/docs/1.0.0/symbolist.symbioticexception.md)<br>
One or more items could not be removed from the list

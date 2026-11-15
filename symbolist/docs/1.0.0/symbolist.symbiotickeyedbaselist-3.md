# SymbioticKeyedBaseList&lt;TList, TItem, TKey&gt;

Namespace: symbolist

Represents the base behavior for a keyed symbiotic list

```csharp
public abstract class SymbioticKeyedBaseList<TList, TItem, TKey> : SymbioticBaseList`2, IReadOnlyList`1, IReadOnlyCollection`1, IEnumerable`1, System.Collections.IEnumerable where TList : SymbioticKeyedBaseList<TList, TItem, TKey> where TItem : SymbioticKeyedBaseItem<TList, TItem, TKey>
```

#### Type Parameters

`TList`<br>

`TItem`<br>

`TKey`<br>

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → SymbioticBaseList&lt;TList, TItem&gt; → [SymbioticKeyedBaseList&lt;TList, TItem, TKey&gt;](https://github.com/blackrookgames/symbolist/tree/main/symbolist/docs/1.0.0/symbolist.symbiotickeyedbaselist-3.md)<br>
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

### **this[TKey]**

```csharp
public TItem this[TKey key] { get; }
```

#### Parameters

`key` TKey<br>

#### Property Value

TItem<br>

### **this[Int32]**

```csharp
public TItem this[int index] { get; }
```

#### Parameters

`index` [Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>

#### Property Value

TItem<br>

## Constructors

### **SymbioticKeyedBaseList()**

Initializer for [SymbioticKeyedBaseList&lt;TList, TItem, TKey&gt;](https://github.com/blackrookgames/symbolist/tree/main/symbolist/docs/1.0.0/symbolist.symbiotickeyedbaselist-3.md)

```csharp
public SymbioticKeyedBaseList()
```

### **SymbioticKeyedBaseList(Int32)**

Initializer for [SymbioticKeyedBaseList&lt;TList, TItem, TKey&gt;](https://github.com/blackrookgames/symbolist/tree/main/symbolist/docs/1.0.0/symbolist.symbiotickeyedbaselist-3.md)

```csharp
public SymbioticKeyedBaseList(int capacity)
```

#### Parameters

`capacity` [Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>
List inital capacity

#### Exceptions

[ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)<br>
`capacity` is negative

## Methods

### **TryGet(TKey, out TItem)**

Attempts to find an item with the specified key

```csharp
public bool TryGet(TKey key, out TItem item)
```

#### Parameters

`key` TKey<br>
Key

`out` `item` TItem<br>
Found item

#### Returns

[Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Whether or not successful

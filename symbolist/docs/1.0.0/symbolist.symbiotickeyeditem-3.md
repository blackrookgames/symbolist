# SymbioticKeyedItem&lt;TList, TItem, TKey&gt;

Namespace: symbolist

Represents a keyed symbiotic list item

```csharp
public abstract class SymbioticKeyedItem<TList, TItem, TKey> : SymbioticKeyedBaseItem`3 where TList : SymbioticKeyedBaseList<TList, TItem, TKey> where TItem : SymbioticKeyedItem<TList, TItem, TKey>
```

#### Type Parameters

`TList`<br>

`TItem`<br>

`TKey`<br>

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → SymbioticItem&lt;TList, TItem&gt; → SymbioticKeyedBaseItem&lt;TList, TItem, TKey&gt; → [SymbioticKeyedItem&lt;TList, TItem, TKey&gt;](https://github.com/blackrookgames/symbolist/tree/main/symbolist/docs/1.0.0/symbolist.symbiotickeyeditem-3.md)<br>
Attributes [NullableAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullableattribute)

## Properties

### **Key**

```csharp
public TKey Key { get; }
```

#### Property Value

TKey<br>

### **List**

```csharp
public TList List { get; }
```

#### Property Value

TList<br>

### **Index**

```csharp
public int Index { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>

## Constructors

### **SymbioticKeyedItem()**

```csharp
protected SymbioticKeyedItem()
```

## Methods

### **SetKey(TKey)**

Sets the key

```csharp
public new void SetKey(TKey key)
```

#### Parameters

`key` TKey<br>
Key

#### Exceptions

[InvalidOperationException](https://learn.microsoft.com/en-us/dotnet/api/system.invalidoperationexception)<br>
Item is already part of a list

**Remarks:**

Only unlisted items can have their keys changed<br>
 Items with null keys cannot be added to lists

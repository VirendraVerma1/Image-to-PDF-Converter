﻿#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





// 0x00000001 System.Exception System.Linq.Error::ArgumentNull(System.String)
extern void Error_ArgumentNull_m0EDA0D46D72CA692518E3E2EB75B48044D8FD41E (void);
// 0x00000002 System.Exception System.Linq.Error::ArgumentOutOfRange(System.String)
extern void Error_ArgumentOutOfRange_m2EFB999454161A6B48F8DAC3753FDC190538F0F2 (void);
// 0x00000003 System.Exception System.Linq.Error::MoreThanOneMatch()
extern void Error_MoreThanOneMatch_m4C4756AF34A76EF12F3B2B6D8C78DE547F0FBCF8 (void);
// 0x00000004 System.Exception System.Linq.Error::NoElements()
extern void Error_NoElements_mB89E91246572F009281D79730950808F17C3F353 (void);
// 0x00000005 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::Where(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000006 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::Select(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,TResult>)
// 0x00000007 System.Func`2<TSource,System.Boolean> System.Linq.Enumerable::CombinePredicates(System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,System.Boolean>)
// 0x00000008 System.Func`2<TSource,TResult> System.Linq.Enumerable::CombineSelectors(System.Func`2<TSource,TMiddle>,System.Func`2<TMiddle,TResult>)
// 0x00000009 TSource[] System.Linq.Enumerable::ToArray(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x0000000A System.Collections.Generic.List`1<TSource> System.Linq.Enumerable::ToList(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x0000000B TSource System.Linq.Enumerable::First(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x0000000C TSource System.Linq.Enumerable::SingleOrDefault(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x0000000D System.Collections.Generic.IEnumerable`1<System.Int32> System.Linq.Enumerable::Range(System.Int32,System.Int32)
extern void Enumerable_Range_mA545670D76B68795D0126AC84B994E2AD66E2415 (void);
// 0x0000000E System.Collections.Generic.IEnumerable`1<System.Int32> System.Linq.Enumerable::RangeIterator(System.Int32,System.Int32)
extern void Enumerable_RangeIterator_m8BC9AE9DF66A6AB3D05D8F7B55D65539133C984A (void);
// 0x0000000F System.Boolean System.Linq.Enumerable::Any(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000010 System.Boolean System.Linq.Enumerable::Any(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000011 System.Int32 System.Linq.Enumerable::Count(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000012 System.Void System.Linq.Enumerable/Iterator`1::.ctor()
// 0x00000013 TSource System.Linq.Enumerable/Iterator`1::get_Current()
// 0x00000014 System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/Iterator`1::Clone()
// 0x00000015 System.Void System.Linq.Enumerable/Iterator`1::Dispose()
// 0x00000016 System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/Iterator`1::GetEnumerator()
// 0x00000017 System.Boolean System.Linq.Enumerable/Iterator`1::MoveNext()
// 0x00000018 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/Iterator`1::Select(System.Func`2<TSource,TResult>)
// 0x00000019 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/Iterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x0000001A System.Object System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerator.get_Current()
// 0x0000001B System.Collections.IEnumerator System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerable.GetEnumerator()
// 0x0000001C System.Void System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerator.Reset()
// 0x0000001D System.Void System.Linq.Enumerable/WhereEnumerableIterator`1::.ctor(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x0000001E System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::Clone()
// 0x0000001F System.Void System.Linq.Enumerable/WhereEnumerableIterator`1::Dispose()
// 0x00000020 System.Boolean System.Linq.Enumerable/WhereEnumerableIterator`1::MoveNext()
// 0x00000021 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereEnumerableIterator`1::Select(System.Func`2<TSource,TResult>)
// 0x00000022 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x00000023 System.Void System.Linq.Enumerable/WhereArrayIterator`1::.ctor(TSource[],System.Func`2<TSource,System.Boolean>)
// 0x00000024 System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereArrayIterator`1::Clone()
// 0x00000025 System.Boolean System.Linq.Enumerable/WhereArrayIterator`1::MoveNext()
// 0x00000026 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereArrayIterator`1::Select(System.Func`2<TSource,TResult>)
// 0x00000027 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereArrayIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x00000028 System.Void System.Linq.Enumerable/WhereListIterator`1::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000029 System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereListIterator`1::Clone()
// 0x0000002A System.Boolean System.Linq.Enumerable/WhereListIterator`1::MoveNext()
// 0x0000002B System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereListIterator`1::Select(System.Func`2<TSource,TResult>)
// 0x0000002C System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereListIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x0000002D System.Void System.Linq.Enumerable/WhereSelectEnumerableIterator`2::.ctor(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
// 0x0000002E System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Clone()
// 0x0000002F System.Void System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Dispose()
// 0x00000030 System.Boolean System.Linq.Enumerable/WhereSelectEnumerableIterator`2::MoveNext()
// 0x00000031 System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Select(System.Func`2<TResult,TResult2>)
// 0x00000032 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Where(System.Func`2<TResult,System.Boolean>)
// 0x00000033 System.Void System.Linq.Enumerable/WhereSelectArrayIterator`2::.ctor(TSource[],System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
// 0x00000034 System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectArrayIterator`2::Clone()
// 0x00000035 System.Boolean System.Linq.Enumerable/WhereSelectArrayIterator`2::MoveNext()
// 0x00000036 System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectArrayIterator`2::Select(System.Func`2<TResult,TResult2>)
// 0x00000037 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectArrayIterator`2::Where(System.Func`2<TResult,System.Boolean>)
// 0x00000038 System.Void System.Linq.Enumerable/WhereSelectListIterator`2::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
// 0x00000039 System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2::Clone()
// 0x0000003A System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2::MoveNext()
// 0x0000003B System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectListIterator`2::Select(System.Func`2<TResult,TResult2>)
// 0x0000003C System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2::Where(System.Func`2<TResult,System.Boolean>)
// 0x0000003D System.Void System.Linq.Enumerable/<>c__DisplayClass6_0`1::.ctor()
// 0x0000003E System.Boolean System.Linq.Enumerable/<>c__DisplayClass6_0`1::<CombinePredicates>b__0(TSource)
// 0x0000003F System.Void System.Linq.Enumerable/<>c__DisplayClass7_0`3::.ctor()
// 0x00000040 TResult System.Linq.Enumerable/<>c__DisplayClass7_0`3::<CombineSelectors>b__0(TSource)
// 0x00000041 System.Void System.Linq.Enumerable/<RangeIterator>d__115::.ctor(System.Int32)
extern void U3CRangeIteratorU3Ed__115__ctor_m3B8C9ADCE5DD64A09B124BD33754D2032A129161 (void);
// 0x00000042 System.Void System.Linq.Enumerable/<RangeIterator>d__115::System.IDisposable.Dispose()
extern void U3CRangeIteratorU3Ed__115_System_IDisposable_Dispose_m309B1CA342B62F07D81D8B0FD41FA270E49AEA40 (void);
// 0x00000043 System.Boolean System.Linq.Enumerable/<RangeIterator>d__115::MoveNext()
extern void U3CRangeIteratorU3Ed__115_MoveNext_m52450B0FF0EA2386F02F97A26B86EEDFB6F428DE (void);
// 0x00000044 System.Int32 System.Linq.Enumerable/<RangeIterator>d__115::System.Collections.Generic.IEnumerator<System.Int32>.get_Current()
extern void U3CRangeIteratorU3Ed__115_System_Collections_Generic_IEnumeratorU3CSystem_Int32U3E_get_Current_m23A5F7D49A4221419AE2C01531FEC54669A78646 (void);
// 0x00000045 System.Void System.Linq.Enumerable/<RangeIterator>d__115::System.Collections.IEnumerator.Reset()
extern void U3CRangeIteratorU3Ed__115_System_Collections_IEnumerator_Reset_mD099802F41E0B4017B1775F7A0F7A0C3EAE5C059 (void);
// 0x00000046 System.Object System.Linq.Enumerable/<RangeIterator>d__115::System.Collections.IEnumerator.get_Current()
extern void U3CRangeIteratorU3Ed__115_System_Collections_IEnumerator_get_Current_mC98C2271FCDACABA4C52610AB5E5A98C08DF2680 (void);
// 0x00000047 System.Collections.Generic.IEnumerator`1<System.Int32> System.Linq.Enumerable/<RangeIterator>d__115::System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator()
extern void U3CRangeIteratorU3Ed__115_System_Collections_Generic_IEnumerableU3CSystem_Int32U3E_GetEnumerator_mF58B1118E0E226A7EC3F79DC9BF2ECF19E9A9B94 (void);
// 0x00000048 System.Collections.IEnumerator System.Linq.Enumerable/<RangeIterator>d__115::System.Collections.IEnumerable.GetEnumerator()
extern void U3CRangeIteratorU3Ed__115_System_Collections_IEnumerable_GetEnumerator_m2FC1ECA81BE4003BFABCDE8654160C8BAD39BC9B (void);
// 0x00000049 System.Void System.Linq.Buffer`1::.ctor(System.Collections.Generic.IEnumerable`1<TElement>)
// 0x0000004A TElement[] System.Linq.Buffer`1::ToArray()
// 0x0000004B System.Void System.Collections.Generic.HashSet`1::.ctor()
// 0x0000004C System.Void System.Collections.Generic.HashSet`1::.ctor(System.Collections.Generic.IEqualityComparer`1<T>)
// 0x0000004D System.Void System.Collections.Generic.HashSet`1::.ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
// 0x0000004E System.Void System.Collections.Generic.HashSet`1::System.Collections.Generic.ICollection<T>.Add(T)
// 0x0000004F System.Void System.Collections.Generic.HashSet`1::Clear()
// 0x00000050 System.Boolean System.Collections.Generic.HashSet`1::Contains(T)
// 0x00000051 System.Void System.Collections.Generic.HashSet`1::CopyTo(T[],System.Int32)
// 0x00000052 System.Boolean System.Collections.Generic.HashSet`1::Remove(T)
// 0x00000053 System.Int32 System.Collections.Generic.HashSet`1::get_Count()
// 0x00000054 System.Boolean System.Collections.Generic.HashSet`1::System.Collections.Generic.ICollection<T>.get_IsReadOnly()
// 0x00000055 System.Collections.Generic.HashSet`1/Enumerator<T> System.Collections.Generic.HashSet`1::GetEnumerator()
// 0x00000056 System.Collections.Generic.IEnumerator`1<T> System.Collections.Generic.HashSet`1::System.Collections.Generic.IEnumerable<T>.GetEnumerator()
// 0x00000057 System.Collections.IEnumerator System.Collections.Generic.HashSet`1::System.Collections.IEnumerable.GetEnumerator()
// 0x00000058 System.Void System.Collections.Generic.HashSet`1::GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
// 0x00000059 System.Void System.Collections.Generic.HashSet`1::OnDeserialization(System.Object)
// 0x0000005A System.Boolean System.Collections.Generic.HashSet`1::Add(T)
// 0x0000005B System.Void System.Collections.Generic.HashSet`1::CopyTo(T[])
// 0x0000005C System.Void System.Collections.Generic.HashSet`1::CopyTo(T[],System.Int32,System.Int32)
// 0x0000005D System.Void System.Collections.Generic.HashSet`1::Initialize(System.Int32)
// 0x0000005E System.Void System.Collections.Generic.HashSet`1::IncreaseCapacity()
// 0x0000005F System.Void System.Collections.Generic.HashSet`1::SetCapacity(System.Int32)
// 0x00000060 System.Boolean System.Collections.Generic.HashSet`1::AddIfNotPresent(T)
// 0x00000061 System.Int32 System.Collections.Generic.HashSet`1::InternalGetHashCode(T)
// 0x00000062 System.Void System.Collections.Generic.HashSet`1/Enumerator::.ctor(System.Collections.Generic.HashSet`1<T>)
// 0x00000063 System.Void System.Collections.Generic.HashSet`1/Enumerator::Dispose()
// 0x00000064 System.Boolean System.Collections.Generic.HashSet`1/Enumerator::MoveNext()
// 0x00000065 T System.Collections.Generic.HashSet`1/Enumerator::get_Current()
// 0x00000066 System.Object System.Collections.Generic.HashSet`1/Enumerator::System.Collections.IEnumerator.get_Current()
// 0x00000067 System.Void System.Collections.Generic.HashSet`1/Enumerator::System.Collections.IEnumerator.Reset()
static Il2CppMethodPointer s_methodPointers[103] = 
{
	Error_ArgumentNull_m0EDA0D46D72CA692518E3E2EB75B48044D8FD41E,
	Error_ArgumentOutOfRange_m2EFB999454161A6B48F8DAC3753FDC190538F0F2,
	Error_MoreThanOneMatch_m4C4756AF34A76EF12F3B2B6D8C78DE547F0FBCF8,
	Error_NoElements_mB89E91246572F009281D79730950808F17C3F353,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	Enumerable_Range_mA545670D76B68795D0126AC84B994E2AD66E2415,
	Enumerable_RangeIterator_m8BC9AE9DF66A6AB3D05D8F7B55D65539133C984A,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	U3CRangeIteratorU3Ed__115__ctor_m3B8C9ADCE5DD64A09B124BD33754D2032A129161,
	U3CRangeIteratorU3Ed__115_System_IDisposable_Dispose_m309B1CA342B62F07D81D8B0FD41FA270E49AEA40,
	U3CRangeIteratorU3Ed__115_MoveNext_m52450B0FF0EA2386F02F97A26B86EEDFB6F428DE,
	U3CRangeIteratorU3Ed__115_System_Collections_Generic_IEnumeratorU3CSystem_Int32U3E_get_Current_m23A5F7D49A4221419AE2C01531FEC54669A78646,
	U3CRangeIteratorU3Ed__115_System_Collections_IEnumerator_Reset_mD099802F41E0B4017B1775F7A0F7A0C3EAE5C059,
	U3CRangeIteratorU3Ed__115_System_Collections_IEnumerator_get_Current_mC98C2271FCDACABA4C52610AB5E5A98C08DF2680,
	U3CRangeIteratorU3Ed__115_System_Collections_Generic_IEnumerableU3CSystem_Int32U3E_GetEnumerator_mF58B1118E0E226A7EC3F79DC9BF2ECF19E9A9B94,
	U3CRangeIteratorU3Ed__115_System_Collections_IEnumerable_GetEnumerator_m2FC1ECA81BE4003BFABCDE8654160C8BAD39BC9B,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
};
static const int32_t s_InvokerIndices[103] = 
{
	2063,
	2063,
	2152,
	2152,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	1840,
	1840,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	1075,
	1263,
	1250,
	1219,
	1263,
	1230,
	1230,
	1230,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
};
static const Il2CppTokenRangePair s_rgctxIndices[29] = 
{
	{ 0x02000004, { 48, 4 } },
	{ 0x02000005, { 52, 9 } },
	{ 0x02000006, { 63, 7 } },
	{ 0x02000007, { 72, 10 } },
	{ 0x02000008, { 84, 11 } },
	{ 0x02000009, { 98, 9 } },
	{ 0x0200000A, { 110, 12 } },
	{ 0x0200000B, { 125, 1 } },
	{ 0x0200000C, { 126, 2 } },
	{ 0x0200000E, { 128, 4 } },
	{ 0x0200000F, { 132, 21 } },
	{ 0x02000011, { 153, 2 } },
	{ 0x06000005, { 0, 10 } },
	{ 0x06000006, { 10, 10 } },
	{ 0x06000007, { 20, 5 } },
	{ 0x06000008, { 25, 5 } },
	{ 0x06000009, { 30, 3 } },
	{ 0x0600000A, { 33, 2 } },
	{ 0x0600000B, { 35, 4 } },
	{ 0x0600000C, { 39, 3 } },
	{ 0x0600000F, { 42, 1 } },
	{ 0x06000010, { 43, 3 } },
	{ 0x06000011, { 46, 2 } },
	{ 0x06000021, { 61, 2 } },
	{ 0x06000026, { 70, 2 } },
	{ 0x0600002B, { 82, 2 } },
	{ 0x06000031, { 95, 3 } },
	{ 0x06000036, { 107, 3 } },
	{ 0x0600003B, { 122, 3 } },
};
static const Il2CppRGCTXDefinition s_rgctxValues[155] = 
{
	{ (Il2CppRGCTXDataType)2, 1107 },
	{ (Il2CppRGCTXDataType)3, 3140 },
	{ (Il2CppRGCTXDataType)2, 1865 },
	{ (Il2CppRGCTXDataType)2, 1562 },
	{ (Il2CppRGCTXDataType)3, 5699 },
	{ (Il2CppRGCTXDataType)2, 1167 },
	{ (Il2CppRGCTXDataType)2, 1569 },
	{ (Il2CppRGCTXDataType)3, 5717 },
	{ (Il2CppRGCTXDataType)2, 1564 },
	{ (Il2CppRGCTXDataType)3, 5706 },
	{ (Il2CppRGCTXDataType)2, 1108 },
	{ (Il2CppRGCTXDataType)3, 3141 },
	{ (Il2CppRGCTXDataType)2, 1880 },
	{ (Il2CppRGCTXDataType)2, 1571 },
	{ (Il2CppRGCTXDataType)3, 5724 },
	{ (Il2CppRGCTXDataType)2, 1181 },
	{ (Il2CppRGCTXDataType)2, 1579 },
	{ (Il2CppRGCTXDataType)3, 5754 },
	{ (Il2CppRGCTXDataType)2, 1575 },
	{ (Il2CppRGCTXDataType)3, 5738 },
	{ (Il2CppRGCTXDataType)2, 429 },
	{ (Il2CppRGCTXDataType)3, 14 },
	{ (Il2CppRGCTXDataType)3, 15 },
	{ (Il2CppRGCTXDataType)2, 723 },
	{ (Il2CppRGCTXDataType)3, 2274 },
	{ (Il2CppRGCTXDataType)2, 430 },
	{ (Il2CppRGCTXDataType)3, 18 },
	{ (Il2CppRGCTXDataType)3, 19 },
	{ (Il2CppRGCTXDataType)2, 727 },
	{ (Il2CppRGCTXDataType)3, 2276 },
	{ (Il2CppRGCTXDataType)2, 493 },
	{ (Il2CppRGCTXDataType)3, 431 },
	{ (Il2CppRGCTXDataType)3, 432 },
	{ (Il2CppRGCTXDataType)2, 1168 },
	{ (Il2CppRGCTXDataType)3, 3402 },
	{ (Il2CppRGCTXDataType)2, 1056 },
	{ (Il2CppRGCTXDataType)2, 804 },
	{ (Il2CppRGCTXDataType)2, 875 },
	{ (Il2CppRGCTXDataType)2, 931 },
	{ (Il2CppRGCTXDataType)2, 876 },
	{ (Il2CppRGCTXDataType)2, 932 },
	{ (Il2CppRGCTXDataType)3, 2275 },
	{ (Il2CppRGCTXDataType)2, 870 },
	{ (Il2CppRGCTXDataType)2, 871 },
	{ (Il2CppRGCTXDataType)2, 930 },
	{ (Il2CppRGCTXDataType)3, 2273 },
	{ (Il2CppRGCTXDataType)2, 803 },
	{ (Il2CppRGCTXDataType)2, 874 },
	{ (Il2CppRGCTXDataType)3, 3142 },
	{ (Il2CppRGCTXDataType)3, 3144 },
	{ (Il2CppRGCTXDataType)2, 310 },
	{ (Il2CppRGCTXDataType)3, 3143 },
	{ (Il2CppRGCTXDataType)3, 3152 },
	{ (Il2CppRGCTXDataType)2, 1111 },
	{ (Il2CppRGCTXDataType)2, 1565 },
	{ (Il2CppRGCTXDataType)3, 5707 },
	{ (Il2CppRGCTXDataType)3, 3153 },
	{ (Il2CppRGCTXDataType)2, 902 },
	{ (Il2CppRGCTXDataType)2, 948 },
	{ (Il2CppRGCTXDataType)3, 2281 },
	{ (Il2CppRGCTXDataType)3, 6900 },
	{ (Il2CppRGCTXDataType)2, 1576 },
	{ (Il2CppRGCTXDataType)3, 5739 },
	{ (Il2CppRGCTXDataType)3, 3145 },
	{ (Il2CppRGCTXDataType)2, 1110 },
	{ (Il2CppRGCTXDataType)2, 1563 },
	{ (Il2CppRGCTXDataType)3, 5700 },
	{ (Il2CppRGCTXDataType)3, 2280 },
	{ (Il2CppRGCTXDataType)3, 3146 },
	{ (Il2CppRGCTXDataType)3, 6899 },
	{ (Il2CppRGCTXDataType)2, 1572 },
	{ (Il2CppRGCTXDataType)3, 5725 },
	{ (Il2CppRGCTXDataType)3, 3159 },
	{ (Il2CppRGCTXDataType)2, 1112 },
	{ (Il2CppRGCTXDataType)2, 1570 },
	{ (Il2CppRGCTXDataType)3, 5718 },
	{ (Il2CppRGCTXDataType)3, 3439 },
	{ (Il2CppRGCTXDataType)3, 1567 },
	{ (Il2CppRGCTXDataType)3, 2282 },
	{ (Il2CppRGCTXDataType)3, 1566 },
	{ (Il2CppRGCTXDataType)3, 3160 },
	{ (Il2CppRGCTXDataType)3, 6901 },
	{ (Il2CppRGCTXDataType)2, 1580 },
	{ (Il2CppRGCTXDataType)3, 5755 },
	{ (Il2CppRGCTXDataType)3, 3173 },
	{ (Il2CppRGCTXDataType)2, 1114 },
	{ (Il2CppRGCTXDataType)2, 1578 },
	{ (Il2CppRGCTXDataType)3, 5741 },
	{ (Il2CppRGCTXDataType)3, 3174 },
	{ (Il2CppRGCTXDataType)2, 905 },
	{ (Il2CppRGCTXDataType)2, 951 },
	{ (Il2CppRGCTXDataType)3, 2286 },
	{ (Il2CppRGCTXDataType)3, 2285 },
	{ (Il2CppRGCTXDataType)2, 1567 },
	{ (Il2CppRGCTXDataType)3, 5709 },
	{ (Il2CppRGCTXDataType)3, 6904 },
	{ (Il2CppRGCTXDataType)2, 1577 },
	{ (Il2CppRGCTXDataType)3, 5740 },
	{ (Il2CppRGCTXDataType)3, 3166 },
	{ (Il2CppRGCTXDataType)2, 1113 },
	{ (Il2CppRGCTXDataType)2, 1574 },
	{ (Il2CppRGCTXDataType)3, 5727 },
	{ (Il2CppRGCTXDataType)3, 2284 },
	{ (Il2CppRGCTXDataType)3, 2283 },
	{ (Il2CppRGCTXDataType)3, 3167 },
	{ (Il2CppRGCTXDataType)2, 1566 },
	{ (Il2CppRGCTXDataType)3, 5708 },
	{ (Il2CppRGCTXDataType)3, 6903 },
	{ (Il2CppRGCTXDataType)2, 1573 },
	{ (Il2CppRGCTXDataType)3, 5726 },
	{ (Il2CppRGCTXDataType)3, 3180 },
	{ (Il2CppRGCTXDataType)2, 1115 },
	{ (Il2CppRGCTXDataType)2, 1582 },
	{ (Il2CppRGCTXDataType)3, 5757 },
	{ (Il2CppRGCTXDataType)3, 3440 },
	{ (Il2CppRGCTXDataType)3, 1569 },
	{ (Il2CppRGCTXDataType)3, 2288 },
	{ (Il2CppRGCTXDataType)3, 2287 },
	{ (Il2CppRGCTXDataType)3, 1568 },
	{ (Il2CppRGCTXDataType)3, 3181 },
	{ (Il2CppRGCTXDataType)2, 1568 },
	{ (Il2CppRGCTXDataType)3, 5710 },
	{ (Il2CppRGCTXDataType)3, 6905 },
	{ (Il2CppRGCTXDataType)2, 1581 },
	{ (Il2CppRGCTXDataType)3, 5756 },
	{ (Il2CppRGCTXDataType)3, 2278 },
	{ (Il2CppRGCTXDataType)3, 2279 },
	{ (Il2CppRGCTXDataType)3, 2289 },
	{ (Il2CppRGCTXDataType)2, 805 },
	{ (Il2CppRGCTXDataType)2, 1883 },
	{ (Il2CppRGCTXDataType)2, 886 },
	{ (Il2CppRGCTXDataType)2, 933 },
	{ (Il2CppRGCTXDataType)3, 1908 },
	{ (Il2CppRGCTXDataType)2, 646 },
	{ (Il2CppRGCTXDataType)3, 2476 },
	{ (Il2CppRGCTXDataType)3, 2477 },
	{ (Il2CppRGCTXDataType)3, 2482 },
	{ (Il2CppRGCTXDataType)2, 984 },
	{ (Il2CppRGCTXDataType)3, 2479 },
	{ (Il2CppRGCTXDataType)3, 7164 },
	{ (Il2CppRGCTXDataType)2, 627 },
	{ (Il2CppRGCTXDataType)3, 1561 },
	{ (Il2CppRGCTXDataType)1, 859 },
	{ (Il2CppRGCTXDataType)2, 1889 },
	{ (Il2CppRGCTXDataType)3, 2478 },
	{ (Il2CppRGCTXDataType)1, 1889 },
	{ (Il2CppRGCTXDataType)1, 984 },
	{ (Il2CppRGCTXDataType)2, 1929 },
	{ (Il2CppRGCTXDataType)2, 1889 },
	{ (Il2CppRGCTXDataType)3, 2483 },
	{ (Il2CppRGCTXDataType)3, 2481 },
	{ (Il2CppRGCTXDataType)3, 2480 },
	{ (Il2CppRGCTXDataType)2, 225 },
	{ (Il2CppRGCTXDataType)3, 1570 },
	{ (Il2CppRGCTXDataType)2, 319 },
};
extern const CustomAttributesCacheGenerator g_System_Core_AttributeGenerators[];
IL2CPP_EXTERN_C const Il2CppCodeGenModule g_System_Core_CodeGenModule;
const Il2CppCodeGenModule g_System_Core_CodeGenModule = 
{
	"System.Core.dll",
	103,
	s_methodPointers,
	0,
	NULL,
	s_InvokerIndices,
	0,
	NULL,
	29,
	s_rgctxIndices,
	155,
	s_rgctxValues,
	NULL,
	g_System_Core_AttributeGenerators,
	NULL, // module initializer,
	NULL,
	NULL,
	NULL,
};

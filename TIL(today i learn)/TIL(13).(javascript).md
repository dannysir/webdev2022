# 2022-09-28 TIL

### 특별한 형태의 javascript 배열

---

다양한 형태의 배열이 가능함

```jsx
const data1 = [10, 5, "SanE", null];

const data2 = {
	"SanE",
	"basketball",
	26
};

const data3 = {
	{name : "SanE", age : 26},
	{name : "Danny", age : 25}
};
```

### 다양한 배열 관련 기능(함수)

### push

---

배열 끝에 아이템 추가 

```jsx
const SanArray = ["SanE", 26, 100];
SanArray.push("JNU");
console.log(SanArray);
```

- 결과

```jsx
["SanE", 26, 100, "JNU"]
```

### pop

---

배열의 끝에 이는 아이템을 리턴해주고, 해당 이이템은 배열에서 삭제

```jsx
const SanArray = ["SanE", 26, 100];
let popData = SanArray.pop();
console.log(SanArray);
console.log(popData);
```

- 결과

```jsx
["SanE", 26]
100
```

### shift

---

배열의 첫번째 아이템을 삭제하고, 뒤에 있는 아이템을 앞으로 당김

```jsx
const SanArray = ["SanE", 26, 100];
SanArray.shift();
console.log(SanArray);
```

- 결과

```jsx
[26, 100]
```

### concat

---

두 배열 합치기

```jsx
const sample1 = [1, 2];
const sample2 = ["SanE", 100];
let sample3 = sample1.concat(sample2);
console.log(sample3);
```

- 결과

```jsx
[1, 2, "SanE", 100]
```

### join

---

아이템 사이에 특정 문자열을 넣어서, 모든 아이템을 합쳐서, 하나의 문자열로 만들어줌

```jsx
let SanArray = [1, 2, "SanE", 100];
let SanArrayJoin = SanArray.join("|");
console.log(SanArray);
console.log(SanArrayJoin);
```

- 결과

```jsx
[1, 2, "SanE", 100]
1|2|SanE|100
```

- 참고 : join을 사용하면 string 값으로 바뀐다.

### reverse

---

배열을 역순으로 배치

- 함수 호출시, 역순으로 배치한 배열을 리턴하는 것이 아니라. 현재 배열을 변경함

```jsx
let SanArray = [1, 2, "SanE", 100];
SanArray.reverse();
console.log(SanArray);
```

### slice

---

배열의 일부분을 반환

- slice(a, b) : a 아이템 인덱스부터 시작해서, b-1 아이템 인덱스까지 추출

```jsx
let SanArray = [1, 2, "SanE", 100];
console.log(SanArray.slice(0, 2));
```

- 결과

```jsx
[1,2]
```
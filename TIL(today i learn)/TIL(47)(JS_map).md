# 2022-12-09 TIL

### map()

### 매개변수

---

- callback
    - 새로운 배열 요소를 생성하는 함수, 다음 세 가지 인수를 가집니다.
- currentValue
    - 처리할 현재 요소
- index
    - 처리할 현재 요소의 인덱스
- array
    - map() 을 호출한 배열
- thisArg
    - callback 을 실행할 때 this 로 사용되는 값

### 반환 값

---

배열의 각 요소에 대해 실행한 callback 의 결과를 모은 **새로운 배열**

### 사용 예제

---

### 배열에 있는 숫자들의 제곱근을 구하여 새로운 배열을 만들기

```jsx
let numbers = [1, 16, 25];
let roots = numbers.map(Math.sqrt);
//roots 는 [1, 4, 5]
//numbers 는 그대로 유지
```

### map 을 활용해 배열 속 객체를 재구성하기

```jsx
let kvArray = [{key:1, value:10},
               {key:2, value:20},
               {key:3, value: 30}];

let reformattedArray = kvArray.map(function(obj){
   var rObj = {};
   rObj[obj.key] = obj.value;
   return rObj;
});
// reformattedArray는 [{1:10}, {2:20}, {3:30}]

// kvArray는 그대로
// [{key:1, value:10},
//  {key:2, value:20},
//  {key:3, value: 30}]
```

### 기존 배열에서 각 숫자에 2를 곱하기

```jsx
let numbers = [1, 4, 9];
let doubles = numbers.map(function(num) {
  return num * 2;
});
// doubles는 이제 [2, 8, 18]
// numbers는 그대로 [1, 4, 9]
```
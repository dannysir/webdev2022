# 2022-11-03 TIL

# React

---

```html
<!DOCTYPE html>
<html>
    <body>
        <span>You count 0</span>
        <button id="btn">CLick me</button>        
    
    </body>
    <script>
        let counter = 0;
        const button = document.getElementById("btn");
        const span = document.querySelector("span");
        function handleClick(){
            counter += 1;
            span.innerText = `You count ${counter}`;
        }
        button.addEventListener("click", handleClick);

    </script>
</html>
```

```jsx
const button = document.getElementById("btn");
const span = document.querySelector("span");
function handleClick(){
	span.innerText = `Hello, San`;
	console.log("Click!");
}
button.addEventListener("click", handleClick);
```

우리는 다음과 같은 방식으로 Javascript를 이용해서 HTML을 작성할 수 있고 addEventListener를 이용해서 특정 이벤트들이 일어 났을 때 반응을 만들 수 있다. 

### React

---

앞에서 말했던 코드를 ReactJS 를 이용하면 다음과 같이 바꿀 수 있다.

```jsx
const root = document.getElementById("root");
const span = React.createElement("span", null, "Hello, San");
const btn = React.createElement("button", {
            onClick: () => console.log("Click!"),
        }, "button");

```

React.createElement 를 이용해서 원하는 태그를 만들고 그 테그 안에 원하는 값들을 넣어 줄 수 있다.

예를 들어서 

```html
<span id="SanE" style="background-color: #191919;">hello</span>
```

```jsx
const btn = React.createElement("span", {
					id : "SanE", style : {background-color: #191919;}
        }, "hello");
```

위의 HTML코드를 아래의 코드로 작성할 수 있다. 

### JSX

---

React에서는 본질적으로 렌더링 로직이 UI 로직(이벤트가 처리되는 방식, 시간에 따라 state가 변하는 방식, 화면에 표시하기 위해 데이터가 준비되는 방식 등)과 연결된다는 사실을 받아들입니다.

React는 별도의 파일에 마크업과 로직을 넣어 *기술*을 인위적으로 분리하는 대신, 둘 다 포함하는 “컴포넌트”라고 부르는 느슨하게 연결된 유닛으로 관심사를 분리합니다. 이후 섹션에서 다시 컴포넌트로 돌아오겠지만, JS에 마크업을 넣는 게 익숙해지지 않는다면 이 이야기가 확신을 줄 것입니다.

React는 JSX 사용이 필수는 아니지만, 대부분의 사람은 JavaScript 코드 안에서 UI 관련 작업을 할 때 시각적으로 더 도움이 된다고 생각합니다. 또한 React가 더욱 도움이 되는 에러 및 경고 메시지를 표시할 수 있게 해줍니다.

```jsx
const element = <h1>Hello, world!</h1>;
```

위의 코드는 HTML과 매우 유사해 보인다. 이러한 형태가 바로 JSX이며 JAVASCRIPT를 확장한 문법이다. 그렇다면 위에서 봤던 코드를 JSX를 이용해서 바꿔보면 다음과 같다. 

```jsx
const btn = (
<span
 id="SanE" style="background-color: #191919;"
>
"hello"
</span>
);
```

전체 코드 

```html
<!DOCTYPE html>
<html>
    <body>
        <div id="root"></div>
    </body>
    <script crossorigin src="https://unpkg.com/react@17.0.2/umd/react.production.min.js"></script>
    <script crossorigin src="https://unpkg.com/react-dom@17.0.2/umd/react-dom.production.min.js"></script>
    <script src="https://unpkg.com/@babel/standalone/babel.min.js"></script>
    <script type="text/babel">
        const root = document.getElementById("root");
        const span = React.createElement("span", null, "Hello, San");

        const btn = React.createElement("button", {
            onClick: () => console.log("Click!"),
        }, "button");

        const Title = () => (
            <span
            onMouseEnter = {() => console.log("Enter")}
            >
            Hello,San
            </span>
        );
        const Button = ()=> (
            <button 
            onClick = {() => console.log("SanE")}
            >
            Click Me
            </button>
        );
        const Container =()=> (
            <div>
                <Title />
                <Button />    
            </div>
        );
        ReactDOM.render(<Container/>, root);
    </script>
</html>
```
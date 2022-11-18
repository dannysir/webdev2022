import Button from "./button";
import styles from "./app.module.css";
function App() {
  return (
    <div className="App">
      <h1 className={styles.title}>Hello! </h1>
      <Button text={"continue"} />
    </div>
  );
}

export default App;

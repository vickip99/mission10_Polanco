import React from "react";
import "./App.css";
import Header from "./Header";
import BowlersList from "./Bowlers/BowlersList";

function App() {
  return (
    <div className="App">
      <Header title="Bowlers Information" />
      <BowlersList />
    </div>
  );
}

export default App;

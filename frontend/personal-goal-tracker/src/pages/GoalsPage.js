import React, { useState, useEffect } from "react";
import Header from "../components/Header";
import Footer from "../components/Footer";
import GoalList from "../components/GoalList";

function GoalsPage() {
  const [goals, setGoals] = useState([]);

  useEffect(() => {
    // Burada API'den veya veri kaynağından hedefleri çekin
    fetch("/api/goals")
      .then((response) => response.json())
      .then((data) => setGoals(data));
  }, []);

  return (
    <div>
      <Header />
      <main className="goals-page">
        <h2>Your Goals</h2>
        <GoalList goals={goals} />
      </main>
      <Footer />
    </div>
  );
}

export default GoalsPage;

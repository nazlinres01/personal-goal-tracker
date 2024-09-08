import React, { useState, useEffect } from 'react';
import { useParams } from 'react-router-dom';
import Header from '../components/Header';
import Footer from '../components/Footer';
import './GoalDetailPage.css'; // Eğer özel stil dosyanız varsa

function GoalDetailPage() {
  const { id } = useParams();
  const [goal, setGoal] = useState(null);

  useEffect(() => {
    // Burada API'den hedef detayını çekin
    fetch(`/api/goals/${id}`)
      .then(response => response.json())
      .then(data => setGoal(data));
  }, [id]);

  if (!goal) return <p>Loading...</p>;

  return (
    <div>
      <Header />
      <main className="goal-detail-page">
        <h2>{goal.title}</h2>
        <p>{goal.description}</p>
        <span>Due Date: {goal.dueDate}</span>
        <a href={`/edit-goal/${goal.id}`} className="button">Edit Goal</a>
      </main>
      <Footer />
    </div>
  );
}

export default GoalDetailPage;

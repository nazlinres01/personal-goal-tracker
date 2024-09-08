import React, { useState, useEffect } from 'react';
import { useParams } from 'react-router-dom';
import Header from '../components/Header';
import Footer from '../components/Footer';
import GoalForm from '../components/GoalForm';

function EditGoalPage() {
  const { id } = useParams();
  const [goal, setGoal] = useState(null);

  useEffect(() => {
    // Burada API'den mevcut hedefi çekin
    fetch(`/api/goals/${id}`)
      .then(response => response.json())
      .then(data => setGoal(data));
  }, [id]);

  const handleSubmit = (updatedGoal) => {
    // Burada API'ye hedefi güncelleyin
    fetch(`/api/goals/${id}`, {
      method: 'PUT',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify(updatedGoal)
    })
      .then(response => response.json())
      .then(data => {
        // Hedef güncellendikten sonra yapılacaklar
        console.log('Goal updated:', data);
      });
  };

  if (!goal) return <p>Loading...</p>;

  return (
    <div>
      <Header />
      <main className="edit-goal-page">
        <h2>Edit Goal</h2>
        <GoalForm onSubmit={handleSubmit} initialGoal={goal} />
      </main>
      <Footer />
    </div>
  );
}

export default EditGoalPage;

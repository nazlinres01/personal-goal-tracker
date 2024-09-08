import React from 'react';
import Header from '../components/Header';
import Footer from '../components/Footer';
import GoalForm from '../components/GoalForm';
import './CreateGoalPage.css'; // Eğer özel stil dosyanız varsa

function CreateGoalPage() {
  const handleSubmit = (goal) => {
    // Burada API'ye yeni hedefi gönderin
    fetch('/api/goals', {
      method: 'POST',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify(goal)
    })
      .then(response => response.json())
      .then(data => {
        // Yeni hedef oluşturulduktan sonra yapılacaklar
        console.log('Goal created:', data);
      });
  };

  return (
    <div>
      <Header />
      <main className="create-goal-page">
        <h2>Create New Goal</h2>
        <GoalForm onSubmit={handleSubmit} />
      </main>
      <Footer />
    </div>
  );
}

export default CreateGoalPage;

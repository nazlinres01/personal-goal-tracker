import React from 'react';
import '../styles/GoalItem.css';

function GoalItem({ goal }) {
  return (
    <div className="goal-item">
      <h2>{goal.title}</h2>
      <p>{goal.description}</p>
      <span>Due Date: {goal.dueDate}</span>
    </div>
  );
}

export default GoalItem;

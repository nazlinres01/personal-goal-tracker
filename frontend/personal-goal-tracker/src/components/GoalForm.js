import React, { useState } from 'react';
import '../styles/GoalForm.css';

function GoalForm({ onSubmit, initialGoal = {} }) {
  const [title, setTitle] = useState(initialGoal.title || '');
  const [description, setDescription] = useState(initialGoal.description || '');
  const [dueDate, setDueDate] = useState(initialGoal.dueDate || '');

  const handleSubmit = (event) => {
    event.preventDefault();
    onSubmit({ title, description, dueDate });
  };

  return (
    <form className="goal-form" onSubmit={handleSubmit}>
      <label>
        Title:
        <input
          type="text"
          value={title}
          onChange={(e) => setTitle(e.target.value)}
          required
        />
      </label>
      <label>
        Description:
        <textarea
          value={description}
          onChange={(e) => setDescription(e.target.value)}
          required
        />
      </label>
      <label>
        Due Date:
        <input
          type="date"
          value={dueDate}
          onChange={(e) => setDueDate(e.target.value)}
          required
        />
      </label>
      <button type="submit">Save Goal</button>
    </form>
  );
}

export default GoalForm;

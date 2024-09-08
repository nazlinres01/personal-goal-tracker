import React from 'react';
import GoalItem from './GoalItem';
import './GoalList.css';

function GoalList({ goals }) {
  return (
    <div className="goal-list">
      {goals.map(goal => (
        <GoalItem key={goal.id} goal={goal} />
      ))}
    </div>
  );
}

export default GoalList;

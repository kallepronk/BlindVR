﻿using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/Narration/Dialogue/Node/Action")]
public class DialogueAction : DialogueNode
{
    [SerializeField]
    private DialogueNode m_NextNode;
    public DialogueNode NextNode => m_NextNode;


    public override bool CanBeFollowedByNode(DialogueNode node)
    {
        return m_NextNode == node;
    }

    public override void Accept(DialogueNodeVisitor visitor)
    {
        visitor.Visit(this);
    }
}
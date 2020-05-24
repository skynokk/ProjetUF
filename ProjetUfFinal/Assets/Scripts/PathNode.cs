using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathNode
{
    private Grid<PathNode> grid;
    private Pathfinding pathfinding;

    public int x;
    public int y;

    public int gCost;
    public int hCost;
    public int fCost;

    public bool isWalkable;
    public bool isTrap;
    public PathNode cameFromNode;

    public string test;

    public PathNode(Grid<PathNode> grid, int x, int y)
    {
        this.grid = grid;
        this.x = x;
        this.y = y;
        isWalkable = true;
        isTrap = false;
        test = "";
    }

    public void CalculateFCost()
    {
        fCost = gCost + hCost;
    }

    public void SetIsWalkable(bool isWalkable)
    {
        this.isWalkable = isWalkable;
        grid.TriggerGridObjectChanged(x, y);
    }

    public void SetValue2()
    {
        test = "56";
    }

    public void SetValue()
    {
        if (test == "")
        {
            test = "MUR";
        }
        else if(test == "BOUE")
        {
            test = "MUR";
        }
        else if (test == "MUR")
        {
            test = "";
        }
    }

    public void SetValueBoue()
    {
        if (test == "")
        {
            test = "BOUE";
        }
        else if (test == "MUR")
        {
            test = "BOUE";
        }
        else if (test == "BOUE")
        {
            test = "";
        }
    }

    public override string ToString()
    {
        return test;
    }
}
